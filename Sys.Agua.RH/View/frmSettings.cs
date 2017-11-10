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
using MetroFramework.Controls;
using MetroFramework;

namespace Sys.Agua.RH.View
{
    public partial class frmSettings : MetroForm 
    {
        frmMain frmMain = new frmMain();
        public frmSettings(frmMain frmMain)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            this.frmMain = frmMain;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            for (int i = 3; i < 13; i++)
            {
                MetroTile tile = new MetroTile();
                tile.Size = new Size(50, 50);
                tile.Tag = i;
                tile.Style = (MetroColorStyle)i;
                tile.Click += tile_click;
                flpEstilos.Controls.Add(tile);

            }
        }


        private void tile_click(object sender, EventArgs e)
        {
             metroStyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            frmMain.msm.Style = (MetroColorStyle)((MetroTile)sender).Tag;
        }

        private void mrbtClaro_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbtEscuro.Checked)
            {
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                frmMain.msm.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                metroStyleManager.Theme = MetroThemeStyle.Light;
                frmMain.msm.Theme = MetroThemeStyle.Light;
            }
        }

        private void mbtntBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
