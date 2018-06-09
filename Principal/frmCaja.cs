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
         public frmCaja(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            _BotonLocal = BotonMDI;

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
    }
}
