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
    public partial class frmLogin : Form
    {
        int intentos = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

    public int NoUsuario_Log { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            var listaU = from c in new dbCAJA().Usuarios
                         where c.Activo == true
                         select c.Usuario;        

            this.listBox1.Items.AddRange(listaU.ToArray());

            this.listBox1.Text = listaU.FirstOrDefault().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CLAVE.Text == string.Empty || this.listBox1.Text == string.Empty)
            {
                MessageBox.Show("Nombre de usuario y/o contraseña invalida");
                return;
            }


            var consulta = (from c in new dbCAJA().Usuarios
                            where c.Usuario == listBox1.Text
                            select c.Contraseña).FirstOrDefault().ToString();

            if (consulta == ObtieneEncriptacion(CLAVE.Text))
            {
                var _NoUsuario = Convert.ToInt32((from c in new dbCAJA().Usuarios
                                                  where c.Usuario == listBox1.Text
                                                  select c.NoUsuario).FirstOrDefault().ToString());

                this.NoUsuario_Log = _NoUsuario;


                this.Close();

            }
            else
            {
                intentos++;
                CLAVE.Text = string.Empty;
                if (intentos >= 3) this.Close();
            }
            


        }

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


    }
}
