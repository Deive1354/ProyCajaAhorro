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
            var frm_Socios = new Socios(ref this.OpSocios) { MdiParent = this , WindowState= FormWindowState.Maximized};
 

            frm_Socios.Show();

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
