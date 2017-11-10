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

namespace Sys.Agua.RH.View
{
    public partial class frmFunc : MetroForm
    {
        public frmFunc(frmMain frmMain)
        {
            InitializeComponent();
            this.StyleManager = frmMain.msm;
        }
    }
}
