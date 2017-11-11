namespace Sys.Agua.RH.View
{
    partial class frmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUser = new MetroFramework.Controls.MetroTextBox();
            this.mtxtSenha = new MetroFramework.Controls.MetroTextBox();
            this.mtileLogin = new MetroFramework.Controls.MetroTile();
            this.mbtnSair = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sys.Agua.RH.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(206, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Usuário:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(215, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Senha:";
            // 
            // mtxtUser
            // 
            // 
            // 
            // 
            this.mtxtUser.CustomButton.Image = null;
            this.mtxtUser.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.mtxtUser.CustomButton.Name = "";
            this.mtxtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUser.CustomButton.TabIndex = 1;
            this.mtxtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUser.CustomButton.UseSelectable = true;
            this.mtxtUser.CustomButton.Visible = false;
            this.mtxtUser.Lines = new string[0];
            this.mtxtUser.Location = new System.Drawing.Point(268, 96);
            this.mtxtUser.MaxLength = 32767;
            this.mtxtUser.Name = "mtxtUser";
            this.mtxtUser.PasswordChar = '\0';
            this.mtxtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUser.SelectedText = "";
            this.mtxtUser.SelectionLength = 0;
            this.mtxtUser.SelectionStart = 0;
            this.mtxtUser.ShortcutsEnabled = true;
            this.mtxtUser.Size = new System.Drawing.Size(162, 23);
            this.mtxtUser.TabIndex = 3;
            this.mtxtUser.UseSelectable = true;
            this.mtxtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtSenha
            // 
            // 
            // 
            // 
            this.mtxtSenha.CustomButton.Image = null;
            this.mtxtSenha.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.mtxtSenha.CustomButton.Name = "";
            this.mtxtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSenha.CustomButton.TabIndex = 1;
            this.mtxtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSenha.CustomButton.UseSelectable = true;
            this.mtxtSenha.CustomButton.Visible = false;
            this.mtxtSenha.Lines = new string[0];
            this.mtxtSenha.Location = new System.Drawing.Point(268, 132);
            this.mtxtSenha.MaxLength = 32767;
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.PasswordChar = 'X';
            this.mtxtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenha.SelectedText = "";
            this.mtxtSenha.SelectionLength = 0;
            this.mtxtSenha.SelectionStart = 0;
            this.mtxtSenha.ShortcutsEnabled = true;
            this.mtxtSenha.Size = new System.Drawing.Size(162, 23);
            this.mtxtSenha.TabIndex = 4;
            this.mtxtSenha.UseSelectable = true;
            this.mtxtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtileLogin
            // 
            this.mtileLogin.ActiveControl = null;
            this.mtileLogin.Location = new System.Drawing.Point(351, 186);
            this.mtileLogin.Name = "mtileLogin";
            this.mtileLogin.Size = new System.Drawing.Size(79, 43);
            this.mtileLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.mtileLogin.TabIndex = 5;
            this.mtileLogin.Text = "Login";
            this.mtileLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtileLogin.UseSelectable = true;
            this.mtileLogin.Click += new System.EventHandler(this.mtileLogin_Click);
            // 
            // mbtnSair
            // 
            this.mbtnSair.Location = new System.Drawing.Point(206, 206);
            this.mbtnSair.Name = "mbtnSair";
            this.mbtnSair.Size = new System.Drawing.Size(75, 23);
            this.mbtnSair.TabIndex = 6;
            this.mbtnSair.Text = "Sair";
            this.mbtnSair.UseSelectable = true;
            this.mbtnSair.Click += new System.EventHandler(this.mbtnSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 258);
            this.Controls.Add(this.mbtnSair);
            this.Controls.Add(this.mtileLogin);
            this.Controls.Add(this.mtxtSenha);
            this.Controls.Add(this.mtxtUser);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtUser;
        private MetroFramework.Controls.MetroTextBox mtxtSenha;
        private MetroFramework.Controls.MetroTile mtileLogin;
        private MetroFramework.Controls.MetroButton mbtnSair;
    }
}