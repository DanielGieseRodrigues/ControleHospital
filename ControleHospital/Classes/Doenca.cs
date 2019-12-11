using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHospital.Classes
{
    class Doenca
    {
        public string Nome { get; set; }
        public string CID { get; set; }
        public severidade Severidade { get; set; }
    }
   enum severidade
    {
        baixa ,
        media,
        alta
    }
}
