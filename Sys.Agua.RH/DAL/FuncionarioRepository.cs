using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sys.Agua.RH.Model;
using System.Data;

namespace Sys.Agua.RH.DAL
{
    class FuncionarioRepository
    {
        public SqlCommand insertFun (Funcionario func)
        {
            SqlCommand cmd = new SqlCommand("exec [Sys.Agua.RH.Funcionario.Insert.NewFunc]");
            cmd.Parameters.AddWithValue("@nome_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@cpf_func", func.cpfFunc);
            cmd.Parameters.AddWithValue("@banco", func.nomeFunc);
            cmd.Parameters.AddWithValue("@cont_banco_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@agencia_banco_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@salario_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@codSetor_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@dataAdm", func.nomeFunc);
            cmd.Parameters.Add("@cod_func", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateFun(Funcionario func)
        {
            SqlCommand cmd = new SqlCommand("exec [Sys.Agua.RH.Funcionario.Update.AtuaFunc]");
            cmd.Parameters.AddWithValue("@nome_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@cpf_func", func.cpfFunc);
            cmd.Parameters.AddWithValue("@banco", func.nomeFunc);
            cmd.Parameters.AddWithValue("@cont_banco_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@agencia_banco_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@salario_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@codSetor_func", func.nomeFunc);
            cmd.Parameters.AddWithValue("@dataAdm", func.nomeFunc);
            cmd.Parameters.AddWithValue("@cod_func", func.CodFunc);
            return cmd;
        }
        public SqlCommand selecFunc (string campo, string value)
        {
            SqlCommand cmd = new SqlCommand("elect cod_func as 'Código', cpf_func as 'CPF', nome_func as 'Nome' from db_RH.dbo.funcionario where "+campo+" like '%" + value +"%'");
            return cmd;
        }
    }
}
