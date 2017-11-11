using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Sys.Agua.RH.View
{
    public partial class frmFunc : MetroForm
    {
        public frmFunc(frmMain frmMain)
        {
            InitializeComponent();
            MetroStyleManager msm = frmMain.msm;
            msm.Owner = this;
            this.StyleManager = msm;
        }

        private void frmFunc_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
