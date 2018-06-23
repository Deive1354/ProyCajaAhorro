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
    public partial class frmCuentas : Form
    {
        ToolStripButton _BotonLocal;

        enum Accion { Agregando, Modificando, Eliminando, Nada };
        Accion acc = Accion.Nada;


        public frmCuentas(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            _BotonLocal = BotonMDI;

        }

        private void Cuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._BotonLocal.Enabled = true;
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            this._BotonLocal.Enabled = false;


            Carga_Grid();

        }



        private void Carga_Grid()
        {
            var lista = from x in new dbCAJA().Cuentas
                        select x;
            this.dataGridView1.DataSource = lista.ToList();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmCuentas_Load(object sender, EventArgs e)
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


            OpSalir.Enabled = !false;
            OpAgregar.Enabled = false;
            OpModificar.Enabled = false;
            OpEliminar.Enabled = false;
            OpCancelar.Enabled = true;
            OpGuardar.Enabled = true;
            acc = Accion.Agregando;

        }






        /*
          foreach (Control n in CO.Controls)
                    {
                        if ( n.GetType().Name.Equals(p_control))
                        {
                            n.Text = string.Empty;
                        }
                        
                    }
        */


        private void OpGuardar_Click(object sender, EventArgs e)
        {
            if (IdSocio.Text == "" || NoCuenta.Text == "" || IdCuenta.Text == "")
            {
                MessageBox.Show("No deje campos en blanco");
                return;
            }



            if (acc == Accion.Agregando)


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
                if (x.GetType().Name == "TextBox") x.Visible = false;



            }
            OpSalir.Enabled = !false;
            OpAgregar.Enabled = !false;
            OpModificar.Enabled = !false;
            OpEliminar.Enabled = !false;
            OpCancelar.Enabled = !true;
            OpGuardar.Enabled = !true;
            acc = Accion.Nada;
        }

        private void OpSalir_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpEliminar_Click(object sender, EventArgs e)
        {

        }

        private void OpGuardar_Click_1(object sender, EventArgs e)
        {
            //var IR=new dbCAJA().spCuentas_Apertura()
        }

        private void OpCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
