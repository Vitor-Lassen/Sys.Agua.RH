using Sys.Agua.RH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Agua.RH.DAL
{
    class LoginRepository
    {
        public SqlCommand login(Login login)
        {
            SqlCommand cmd = new SqlCommand("[Sys.Agua.RH.Login.Login]  @usuario,@senha");
            cmd.Parameters.AddWithValue("@usuario", login.usuario);
            cmd.Parameters.AddWithValue("@senha", login.senha);

            return cmd;
        }
        public SqlCommand setTheme(Login login)
        {
            SqlCommand cmd = new SqlCommand("exec [Sys.Agua.RH.Login.Update.SetTheme] @usuario,@tema,@estilo");
            cmd.Parameters.AddWithValue("@usuario", login.usuario);
            cmd.Parameters.AddWithValue("@tema", login.tema);
            cmd.Parameters.AddWithValue("@estilo", login.estilo);
            return cmd;
        }
    }
}
