namespace Sys.Agua.RH.View
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.flpEstilos = new System.Windows.Forms.FlowLayoutPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbltema = new MetroFramework.Controls.MetroLabel();
            this.mrbtClaro = new MetroFramework.Controls.MetroRadioButton();
            this.mrbtEscuro = new MetroFramework.Controls.MetroRadioButton();
            this.mbtntBack = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // flpEstilos
            // 
            this.flpEstilos.Location = new System.Drawing.Point(49, 82);
            this.flpEstilos.Name = "flpEstilos";
            this.flpEstilos.Size = new System.Drawing.Size(286, 161);
            this.flpEstilos.TabIndex = 0;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Estilo:";
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(49, 246);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(43, 19);
            this.lbltema.TabIndex = 2;
            this.lbltema.Text = "Tema:";
            // 
            // mrbtClaro
            // 
            this.mrbtClaro.AutoSize = true;
            this.mrbtClaro.Checked = true;
            this.mrbtClaro.Location = new System.Drawing.Point(98, 273);
            this.mrbtClaro.Name = "mrbtClaro";
            this.mrbtClaro.Size = new System.Drawing.Size(51, 15);
            this.mrbtClaro.TabIndex = 3;
            this.mrbtClaro.TabStop = true;
            this.mrbtClaro.Text = "Claro";
            this.mrbtClaro.UseSelectable = true;
            this.mrbtClaro.CheckedChanged += new System.EventHandler(this.mrbtClaro_CheckedChanged);
            // 
            // mrbtEscuro
            // 
            this.mrbtEscuro.AutoSize = true;
            this.mrbtEscuro.Location = new System.Drawing.Point(98, 294);
            this.mrbtEscuro.Name = "mrbtEscuro";
            this.mrbtEscuro.Size = new System.Drawing.Size(58, 15);
            this.mrbtEscuro.TabIndex = 4;
            this.mrbtEscuro.Text = "Escuro";
            this.mrbtEscuro.UseSelectable = true;
            // 
            // mbtntBack
            // 
            this.mbtntBack.ActiveControl = null;
            this.mbtntBack.Location = new System.Drawing.Point(10, 312);
            this.mbtntBack.Name = "mbtntBack";
            this.mbtntBack.Size = new System.Drawing.Size(50, 50);
            this.mbtntBack.TabIndex = 5;
            this.mbtntBack.TileImage = global::Sys.Agua.RH.Properties.Resources.left_arrow;
            this.mbtntBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtntBack.UseSelectable = true;
            this.mbtntBack.UseTileImage = true;
            this.mbtntBack.Click += new System.EventHandler(this.mbtntBack_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 373);
            this.Controls.Add(this.mbtntBack);
            this.Controls.Add(this.mrbtEscuro);
            this.Controls.Add(this.mrbtClaro);
            this.Controls.Add(this.lbltema);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.flpEstilos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 373);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 373);
            this.Name = "frmSettings";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEstilos;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLabel lbltema;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton mrbtEscuro;
        private MetroFramework.Controls.MetroRadioButton mrbtClaro;
        private MetroFramework.Controls.MetroTile mbtntBack;
    }
}