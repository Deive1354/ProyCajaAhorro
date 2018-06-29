using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Principal
{
    public partial class FrmUsuarios : Form

    {
        ToolStripButton _BotonLocal;

        enum Accion { Agregando, Modificando, Eliminando, Nada };
        Accion acc = Accion.Nada;


        public static string ObtieneEncriptacion(string cadena)
        {
            var md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(cadena));

            var sBuilder = new StringBuilder();

            for (Int16 i = 0; i <= data.Length - 1; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }
            return sBuilder.ToString();
        }



        public FrmUsuarios(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            _BotonLocal = BotonMDI;

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this._BotonLocal.Enabled = false;


            Carga_Grid();

        }


        private void Carga_Grid()
        {
            var lista = from x in new dbCAJA().Usuarios
                        select x;
            this.dataGridView1.DataSource = lista.ToList();
        }


        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activo_Click(object sender, EventArgs e)
        {

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




        private void OpGuardar_Click(object sender, EventArgs e)
        {

            if (txtusuarios.Text == "" || txtcontraseña.Text == "" || txtnodeusuario.Text == "")
            {
                MessageBox.Show("campos vacios revise su captura");
                return;
            }



            if (acc == Accion.Agregando)
            {

                var _db = new dbCAJA();
                var reg = new Usuarios();

                reg.Contraseña = this.txtcontraseña.Text;
                reg.NoUsuario = 1;
                reg.Activo = true;
                reg.Usuario = this.txtusuarios.Text;

                _db.Usuarios.InsertOnSubmit(reg);
                _db.SubmitChanges();
            }

            CancelaAccion();
            Carga_Grid();

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

            DataGridViewRow row = this.dataGridView1.Rows[i];
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
            this.dataGridView1.DataSource = g.ToList();

            CancelaAccion();
            Carga_Grid();
        }
     
        private void OpModificar_Click(object sender, EventArgs e)
        {

            int i = bindingSource1.Position;

            if (i == -1) return;

            DataGridViewRow r = this.dataGridView1.Rows[bindingSource1.Position];
            MuestraRegistro(r);

            OpAgregar.Enabled = false;
            OpModificar.Enabled = false;
            OpEliminar.Enabled = false;
            OpCancelar.Enabled = true;
            OpGuardar.Enabled = true;
            dataGridView1.Enabled = false;
            bindingNavigator1.Enabled = false;
            acc = Accion.Modificando;
            //txtTipoCuenta.Focus();
        }
 
        private bool SePuedeEliminar()
        {
            DataGridViewRow row = this.dataGridView1.Rows[this.bindingSource1.Position];
            var _IdCta = Convert.ToInt32(row.Cells["IdCta"].Value.ToString());

            var r = (from n in new dbCAJA().Usuarios
                     where n.NoUsuario == _IdCta
                     select n).Count();

            if (r > 0) MessageBox.Show("No se puede eliminar tiene cuentas de inversio");

            return r == 0;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //int i = bindingSource1.Position;

            if (i == -1) return;
            DataGridViewRow r = this.dataGridView1.Rows[i];
            MuestraRegistro(r);


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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtcontraseña.Text = ObtieneEncriptacion("0");
            //MessageBox.Show(txtcontraseña.TextLength.ToString());

        }


        private void OpSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        private void OpGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtnodeusuario.Text == "" || txtcontraseña.Text == "" || txtusuarios.Text == "")
            {
                MessageBox.Show("campos vacios revise su captura");
                return;
            }



            if (acc == Accion.Agregando)
            {

                var _db = new dbCAJA();
                var reg = new Usuarios ();

                reg.Usuario = this.txtusuarios.Text;
                reg.Contraseña = this.txtcontraseña.Text;
                reg.NoUsuario = Convert.ToInt32(this.txtnodeusuario.Text);
                reg.Activo = true;


                _db.Usuarios.InsertOnSubmit(reg);
                _db.SubmitChanges();


            }


            CancelaAccion();
            Carga_Grid();
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._BotonLocal.Enabled = true;
        }

        private void OpAgregar_Click_1(object sender, EventArgs e)
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

        private void OpCancelar_Click_1(object sender, EventArgs e)
        {
            CancelaAccion();
        }

       
        private void OpModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //int i = bindingSource1.Position;

            if (i == -1) return;
            DataGridViewRow r = this.dataGridView1.Rows[i];
            MuestraRegistro(r);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }




        private void MuestraRegistro(DataGridViewRow row)
            {
                if (acc != Accion.Nada) return;

                this.txtusuarios.Text = row.Cells["usuario"].Value.ToString();
                this.txtcontraseña.Text = row.Cells["contraseña"].Value.ToString();
                this.txtnodeusuario.Text = row.Cells["nousuario"].Value.ToString();
                this.checkactivo.CheckState = bool.Parse(row.Cells["Activo"].Value.ToString()) == true ? CheckState.Checked : CheckState.Unchecked;
            }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex > -1)
                {
                    this.Text = e.ColumnIndex.ToString();
                }
            }
        }
    }
}
