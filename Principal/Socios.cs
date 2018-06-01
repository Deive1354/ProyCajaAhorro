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
    public partial class Socios : Form
    {
        ToolStripButton _BotonLocal;

        public Socios(ref ToolStripButton BotonMDI)
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
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpAgregar_Click(object sender, EventArgs e)
        {

        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
