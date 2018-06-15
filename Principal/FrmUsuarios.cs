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

        }

        private void OpModificar_Click(object sender, EventArgs e)
        {

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
