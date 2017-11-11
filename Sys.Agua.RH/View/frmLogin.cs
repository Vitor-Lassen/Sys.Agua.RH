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
using Sys.Agua.RH.Model;
using Sys.Agua.RH.DataBase;
using Sys.Agua.RH.DAL;
using MetroFramework;

namespace Sys.Agua.RH.View
{
    public partial class frmLogin : MetroForm 
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void mbtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtileLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                login.usuario = mtxtUser.Text;
                login.senha = mtxtSenha.Text;
                DataSet ds = new DataSet();
                ds = new Connection().execQuery(new LoginRepository().login(login));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    login.nome = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    login.tema = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[3].ToString());
                    login.estilo = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário ou senha Inválidos", "Falha ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Falha ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
