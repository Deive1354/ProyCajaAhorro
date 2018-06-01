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

       
    public partial class frmSocios : Form
    {
        ToolStripButton _BotonLocal;

        enum Accion { Agregando, Modificando, Eliminando, Nada };
        Accion acc = Accion.Nada;
       

        public frmSocios(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            _BotonLocal = BotonMDI;

        }

        private void Socios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._BotonLocal.Enabled = true;
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            this._BotonLocal.Enabled = false;


            Carga_Grid();

        }




        private void Carga_Grid()
        {
            var lista = from x in new dbCAJA().SociosV
                        select x;
            this.dataGridView1.DataSource = lista.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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






        /*
          foreach (Control n in CO.Controls)
                    {
                        if ( n.GetType().Name.Equals(p_control))
                        {
                            n.Text = string.Empty;
                        }
                        
                    }
        */
        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpGuardar_Click(object sender, EventArgs e)
        {
            if(txtSocio.Text == "" || rfc.Text=="" || domicilio.Text=="" )
            {
                MessageBox.Show("campos vacios revise su captura");
                return;
            }



            if (acc == Accion.Agregando) 
            {

                var _db = new dbCAJA();
                var reg =new SOCIOS();

                reg.Socio = this.txtSocio.Text;
                reg.RFC = this.rfc.Text;
                reg.Domicilio = this.domicilio.Text;
                reg.NoUsuario = 1;
                reg.Activo = true;
                reg.BuroCredito = false;

                _db.SOCIOS.InsertOnSubmit(reg);
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


    }
}
