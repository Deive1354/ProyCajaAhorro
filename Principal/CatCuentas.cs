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
    public partial class CatCuentas : Form
    {
        ToolStripButton _BotonLocal;


        public CatCuentas(ref ToolStripButton BotonMDI)
        {
            InitializeComponent();
            _BotonLocal = BotonMDI;
            _BotonLocal.Enabled = false;
        }

        private void CatCuentas_Load(object sender, EventArgs e)
        {

        }

        private void CatCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _BotonLocal.Enabled = true;
        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
