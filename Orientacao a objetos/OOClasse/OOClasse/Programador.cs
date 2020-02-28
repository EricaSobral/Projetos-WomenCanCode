using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
  public  class Programador : Pessoa
    {
        public Programador(int anosCarreira, bool possuiGraduacao)
        {
            Linguagens = new List<string>();
            AnosCarreira = anosCarreira;
            PossuiGraduacao = possuiGraduacao;
        }
        public List<string> Linguagens { get; set; }

        public int AnosCarreira { get; set; }

        public bool PossuiGraduacao { get; set; }

        public bool TrabalhaNaArea { get; set; }

        public decimal Salario { get; set; }

    }
}
