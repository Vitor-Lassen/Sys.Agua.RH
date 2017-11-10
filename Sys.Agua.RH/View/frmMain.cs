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
using Sys.Agua.RH.View;

namespace Sys.Agua.RH
{
    public partial class frmMain : MetroForm
    {
        public MetroFramework.Components.MetroStyleManager msm = new MetroFramework.Components.MetroStyleManager();
        public frmMain()
        {
            InitializeComponent();
            
            msm.Owner = this;
            this.StyleManager = msm;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings(this);
            settings.ShowDialog();
        }

        private void mbtntFunc_Click(object sender, EventArgs e)
        {
            frmFunc func = new frmFunc(this);
            func.ShowDialog();
        }
    }
}
