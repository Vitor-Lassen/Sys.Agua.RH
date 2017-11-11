using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Agua.RH.DAL
{
    class SetorRepository
    {
        public SqlCommand selecSetor()
        {
            SqlCommand cmd = new SqlCommand("select * from setor ");
            return cmd;
        }
    }
}
