namespace Sys.Agua.RH
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.mbtntFunc = new MetroFramework.Controls.MetroTile();
            this.btnSettings = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mbtntFunc
            // 
            this.mbtntFunc.ActiveControl = null;
            this.mbtntFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtntFunc.Location = new System.Drawing.Point(63, 88);
            this.mbtntFunc.Name = "mbtntFunc";
            this.mbtntFunc.Size = new System.Drawing.Size(180, 180);
            this.mbtntFunc.TabIndex = 1;
            this.mbtntFunc.Text = "Funcionários";
            this.mbtntFunc.TileImage = global::Sys.Agua.RH.Properties.Resources.user_silhouette;
            this.mbtntFunc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtntFunc.UseSelectable = true;
            this.mbtntFunc.UseTileImage = true;
            this.mbtntFunc.Click += new System.EventHandler(this.mbtntFunc_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveControl = null;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(766, 268);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(50, 50);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TileImage = global::Sys.Agua.RH.Properties.Resources.pencil;
            this.btnSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip.SetToolTip(this.btnSettings, "Configurações");
            this.btnSettings.UseSelectable = true;
            this.btnSettings.UseTileImage = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 341);
            this.Controls.Add(this.mbtntFunc);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmMain";
            this.Text = "RH";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSettings;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroTile mbtntFunc;
    }
}

