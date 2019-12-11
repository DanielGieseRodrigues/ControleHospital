using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHospital.Classes
{
    class Paciente
    {
        public Pessoa Pessoa{ get; set; }
        public Doenca Doenca { get; set; }
        public Medicamento Medicamento { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public string NomePaciente
        {
            get { return this.Pessoa.Nome; }
        }
    }
}
