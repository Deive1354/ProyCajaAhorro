using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class frmCatCuentas : Form
    {
        ToolStripButton _BotonLocal;


        enum Accion { Agregando, Modificando, Eliminando, Nada };
        Accion acc = Accion.Nada;
        int NoUsuario = 0;

        public frmCatCuentas(ref ToolStripButton BotonMDI, int NoUsuarioMDI)
        {
            InitializeComponent();
            _BotonLocal = BotonMDI;
            _BotonLocal.Enabled = false;
            this.NoUsuario = NoUsuarioMDI;
        }

        private void CatCuentas_Load(object sender, EventArgs e)
        {
             this._BotonLocal.Enabled = false;

            Carga_Grid();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ReadOnly = true;

            this.dataGridView2.Columns["Idcta"].Width = 50;
            this.dataGridView2.Columns["TipoCuenta"].Width = 200;
            this.dataGridView2.Columns["MontoMinimo"].Width = 70;
            this.dataGridView2.Columns["TasaInteres"].Width = 70;
            this.dataGridView2.Columns["PlazoForsozo"].Width = 80;          
            this.dataGridView2.Columns["Activo"].Width = 50;

        }




        private void Carga_Grid()
        {
            var lista = from x in new dbCAJA().CatCuentas   select x;

            bindingSource1.DataSource = lista.ToList();

            this.dataGridView2.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;


        }
        




        private void CatCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _BotonLocal.Enabled = true;
        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpAgregar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                x.Visible = true;
                if (x.GetType().Name == "TextBox")
                {
                    x.Text = "";
                }
            }

           

            OpAgregar.Enabled = false;
            OpModificar.Enabled = false;
            OpEliminar.Enabled = false;
            OpCancelar.Enabled = true;
            OpGuardar.Enabled = true;
            dataGridView2.Enabled = false;
            bindingNavigator1.Enabled = false;
            acc = Accion.Agregando;
        }

        private void OpGuardar_Click(object sender, EventArgs e)
        {

            if (txtTipoCuenta.Text == "" || txtMontoMinimo.Text == "" || txtPlazoForsozo.Text == "")
            {
                MessageBox.Show("campos vacios revise su captura");
                return;
            }


            if (acc == Accion.Agregando)
            {

                var _db = new dbCAJA();
                var reg = new CatCuentas();


                reg.TipoCuenta = this.txtTipoCuenta.Text;
                reg.MontoMinimo = Convert.ToDecimal(this.txtMontoMinimo.Text);
                reg.TasaInteres = Convert.ToDecimal(this.txtTasaInteres.Text);
                reg.PlazoForsozo = Convert.ToInt32(this.txtPlazoForsozo.Text);
                reg.Activo = true;
                reg.NoUsuario = this.NoUsuario;

                _db.CatCuentas.InsertOnSubmit(reg);
                _db.SubmitChanges();



                CancelaAccion();
                Carga_Grid();

            }

            if (acc == Accion.Modificando)
            {

                try
                {
                    var reg = new CatCuentas();
                    var _db = new dbCAJA();

                    DataGridViewRow row = this.dataGridView2.Rows[bindingSource1.Position];
                    var _IdCta =Convert.ToInt32(row.Cells["IdCta"].Value.ToString());
                    var _Activo = this.checkActivo.Checked;

                    CatCuentas result = (from u in _db.CatCuentas
                                         where u.IdCta == _IdCta
                                         select u).Single();

                    result.IdCta = _IdCta;
                    result.TipoCuenta = this.txtTipoCuenta.Text;
                    result.TasaInteres = Convert.ToDecimal(this.txtTasaInteres.Text);
                    result.PlazoForsozo = Convert.ToInt32(this.txtPlazoForsozo.Text);
                    result.MontoMinimo = Convert.ToDecimal(this.txtMontoMinimo.Text);

                    _db.CatCuentas.InsertOnSubmit(result);
                    _db.SubmitChanges();


                    CancelaAccion();
                    Carga_Grid();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                
                }
               
            }
        }
        
            

        private void OpCancelar_Click(object sender, EventArgs e)
        {
            
            CancelaAccion();
        }

         private void CancelaAccion()
        {
            foreach (Control x in this.Controls)
            {

                if (x.GetType().Name == "TextBox")
                {
                    x.Text = "";
                    x.Visible = false;
                }

                if (x.GetType().Name == "Label") x.Visible = false;
                if (x.GetType().Name == "CheckBox") x.Visible = false;
            }

            OpAgregar.Enabled = !false;
            OpModificar.Enabled = !false;
            OpEliminar.Enabled = !false;
            OpCancelar.Enabled = !true;
            OpGuardar.Enabled = !true;
            dataGridView2.Enabled = true;
            bindingNavigator1.Enabled = true;
            acc = Accion.Nada;
        }

              private void OpModificar_Click(object sender, EventArgs e)
              {
                  int i = bindingSource1.Position;

                  if (i == -1) return;

                  DataGridViewRow r = this.dataGridView2.Rows[bindingSource1.Position];
                  MuestraRegistro(r);

                 OpAgregar.Enabled = false;
                 OpModificar.Enabled = false;
                 OpEliminar.Enabled = false;
                 OpCancelar.Enabled = true;
                 OpGuardar.Enabled = true;
                 dataGridView2.Enabled = false;
                 bindingNavigator1.Enabled = false;
                 acc = Accion.Modificando;
                 txtTipoCuenta.Focus();
              }

              private bool SePuedeEliminar()
              {
                  DataGridViewRow row = this.dataGridView2.Rows[this.bindingSource1.Position];
                  var _IdCta = Convert.ToInt32(row.Cells["IdCta"].Value.ToString());

                  var r = (from n in new dbCAJA().CatCuentas
                           where n.IdCta == _IdCta
                           select n).Count();

                  if (r > 0) MessageBox.Show("No se puede eliminar tiene cuentas de inversio");

                  return r == 0;
  
              }

              private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
              {
                  int i = e.RowIndex;
                  //int i = bindingSource1.Position;

                  if (i == -1) return;
                  DataGridViewRow r = this.dataGridView2.Rows[i];
                  MuestraRegistro(r);


              }
              private void MuestraRegistro(DataGridViewRow row)
              {

                  if (acc != Accion.Nada) return;

                  this.txtMontoMinimo.Text = row.Cells["MontoMinimo"].Value.ToString();
                  this.txtPlazoForsozo.Text = row.Cells["PlazoForsozo"].Value.ToString();
                  this.txtTasaInteres.Text = row.Cells["TasaInteres"].Value.ToString();
                  this.txtTipoCuenta.Text = row.Cells["TipoCuenta"].Value.ToString();
                  this.checkActivo.CheckState = bool.Parse(row.Cells["Activo"].Value.ToString()) == true ? CheckState.Checked : CheckState.Unchecked;
              
              }

              private void dataGridView2_RowLeave(object sender, DataGridViewCellEventArgs e)
              {
                  if (e.RowIndex > -1)
                  {
                      this.Text = e.ColumnIndex.ToString();
                  }
              }

              private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
              {

              }

              private void OpEliminar_Click(object sender, EventArgs e)
              {
                  int i = bindingSource1.Position;
                  if (i == -1)
                  {
                      MessageBox.Show("No hay registros activos para eliminar");
                      return;
                  }

                  if (!SePuedeEliminar()) return;

                  DataGridViewRow row = this.dataGridView2.Rows[i];
                  var msg = string.Format("Desea Eliminar El Registro S/N\n\n\nTipoCuenta => {0}\n\nMontoMinimo => {1}", row.Cells["TipoCuenta"].Value.ToString(), row.Cells["MontoMinimo"].Value.ToString());
                  if (MessageBox.Show(msg, "mensaje", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                  var _TipoCuenta = (row.Cells["TipoCuenta"].Value.ToString());
                  var _db = new dbCAJA();



                  CatCuentas result = (from u in _db.CatCuentas
                                       where u.TipoCuenta == _TipoCuenta
                                       select u).Single();

                  _db.CatCuentas.DeleteOnSubmit(result);
                  _db.SubmitChanges();

                  var g = from x in new dbCAJA().CatCuentas select x;
                  this.dataGridView2.DataSource = g.ToList();

                  CancelaAccion();
                  Carga_Grid();
              }




        }
    }

