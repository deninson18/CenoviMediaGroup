using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentPrestam
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea Salir?", "ADVERTENCIA !", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
            {

                e.Cancel = true;

            }
        }
    }
}
