using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Agua.RH.Model
{
    class Funcionario
    {
        public int CodFunc { get; set; }//output
        public string nomeFunc { get; set; }
        public string cpfFunc { get; set; }
        public string bancoFunc { get; set; }
        public int contBancoFunc { get; set; }
        public int agenBancoFunc { get; set; }
        public double salarioFunc { get; set; }
        public int codSetor { get; set; }
        public DateTime dataAdmFunc { get; set; }
    }
}
