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
            this.btnSettings = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mbtntFunc = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveControl = null;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(515, 428);
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
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Location = new System.Drawing.Point(296, 298);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(180, 180);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.TabStop = false;
            this.metroTile2.Text = "Exportação de dados";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = global::Sys.Agua.RH.Properties.Resources._216190_128;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.Location = new System.Drawing.Point(66, 298);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(180, 180);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Importação de dados";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = global::Sys.Agua.RH.Properties.Resources._326535_128;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(296, 76);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(180, 180);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Relatório de Holerites";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::Sys.Agua.RH.Properties.Resources._2102048_128;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mbtntFunc
            // 
            this.mbtntFunc.ActiveControl = null;
            this.mbtntFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtntFunc.Location = new System.Drawing.Point(66, 76);
            this.mbtntFunc.Name = "mbtntFunc";
            this.mbtntFunc.Size = new System.Drawing.Size(180, 180);
            this.mbtntFunc.TabIndex = 1;
            this.mbtntFunc.Text = "Funcionários";
            this.mbtntFunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mbtntFunc.TileImage = global::Sys.Agua.RH.Properties.Resources.user_silhouette;
            this.mbtntFunc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtntFunc.UseSelectable = true;
            this.mbtntFunc.UseTileImage = true;
            this.mbtntFunc.Click += new System.EventHandler(this.mbtntFunc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sys.Agua.RH.Properties.Resources.teste;
            this.BackImage = global::Sys.Agua.RH.Properties.Resources.teste;
            this.ClientSize = new System.Drawing.Size(606, 510);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mbtntFunc);
            this.Controls.Add(this.btnSettings);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "frmMain";
            this.Text = "RH";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSettings;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroTile mbtntFunc;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}

