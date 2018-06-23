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
    public partial class Caja : Form
    {
        ToolStripButton cj;

        public Caja(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();

            cj = BotonMDI;

        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Caja_Load(object sender, EventArgs e)
        {

        }
    }
}
