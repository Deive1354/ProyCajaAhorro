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
    public partial class MDI : Form
    {
        public int NoUsuario = 0;

        public MDI()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpSocios_Click(object sender, EventArgs e)
        {
            var frm_Socios = new frmSocios(ref this.OpSocios) { MdiParent = this , WindowState= FormWindowState.Maximized}; 
            frm_Socios.Show();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            //var frm_acceso = new frmLogin() {  StartPosition = FormStartPosition.CenterScreen };            
            //frm_acceso.ShowDialog();
            //this.NoUsuario = frm_acceso.NoUsuario_Log;
            
            
            //TEMP
            this.NoUsuario = 1;
            toolStrip1.Enabled = true;


             

        }

        private void OpCatInversiones_Click(object sender, EventArgs e)
        {
            var fromCatCuentas = new frmCatCuentas(ref OpCatInversiones,this.NoUsuario) { MdiParent = this, WindowState = FormWindowState.Maximized };


            //  fromCatCuentas.MdiParent = this;


            fromCatCuentas.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var Caja = new frmCaja(ref toolStripButton5) { MdiParent = this, WindowState = FormWindowState.Maximized };
             Caja.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var Usuarios = new FrmUsuarios(ref toolStripButton6) { MdiParent = this, WindowState = FormWindowState.Maximized };
            Usuarios.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var Cuentas = new frmCuentas(ref toolStripButton4) { MdiParent = this, WindowState = FormWindowState.Maximized };
            Cuentas.Show();
        }
        
    }
}
