using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TDI_2
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaculatrice f = new frmCaculatrice();
            f.Show();
        }
    }
}
