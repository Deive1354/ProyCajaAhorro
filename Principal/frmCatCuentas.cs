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
            
        }




        private void Carga_Grid()
        {
            var lista = from x in new dbCAJA().CatCuentas
                        select x;
            this.dataGridView2.DataSource = lista.ToList();
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
            acc = Accion.Agregando;
        }

        private void OpGuardar_Click(object sender, EventArgs e)
        {

            if (txtTipoCuenta.Text == "" || txtMontoMinimo.Text == "" || txtPlazoForsozo.Text == ""  )
            {
                MessageBox.Show("campos vacios revise su captura");
                return;
            }


            if (acc == Accion.Agregando)
            {

                var _db = new dbCAJA();
                var reg = new CatCuentas();

                reg.TipoCuenta = this.txtTipoCuenta.Text;
                reg.MontoMinimo =Convert.ToDecimal(this.txtMontoMinimo.Text);
                reg.TasaInteres =Convert.ToDecimal( this.txtTasaInteres.Text);               
                reg.PlazoForsozo = Convert.ToInt32(this.txtPlazoForsozo.Text);
                reg.Activo = true;
                reg.NoUsuario = this.NoUsuario;

                _db.CatCuentas.InsertOnSubmit(reg);
                _db.SubmitChanges();
            }

            CancelaAccion();
            Carga_Grid();


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
            acc = Accion.Nada;
        }

              private void OpModificar_Click(object sender, EventArgs e)
              {

              }




        }
    }

