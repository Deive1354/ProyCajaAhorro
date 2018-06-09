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
    public partial class frmCaja : Form
    { 
          ToolStripButton _BotonLocal;

          enum Accion { Agregando, Modificando, Eliminando, Nada };
            Accion acc = Accion.Nada;



         public frmCaja(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            _BotonLocal = BotonMDI;
            _BotonLocal.Enabled =  false;

        }

         private void Caja_Load(object sender, EventArgs e)
         {
             this._BotonLocal.Enabled = false;


             Carga_Grid();

         }




         private void Carga_Grid()
         {
             var lista = from x in new dbCAJA().Caja
                         select x;
             this.dataGridView4.DataSource = lista.ToList();
         }


        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void OpGuardar_Click(object sender, EventArgs e)
        {
            if (NoMvto.Text =="" || NoCu.Text =="" || NoUsuario.Text ==""  )
            {
                MessageBox.Show("LLene los campos vacios ");
                return;
            }


            if (acc == Accion.Agregando)
            {

                var _db = new dbCAJA();
                var cs = new Caja();
                var nc = NoCu.Text;
                cs.FechaMvto = this.dateTimePicker1.Value;
               
                _db.Caja.InsertOnSubmit(cs);
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

                if (x.GetType().Name == "Label") 
                    x.Visible = false;
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
