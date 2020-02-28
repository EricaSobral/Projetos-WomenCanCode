using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramacao.Models
{
    public class Notas
    {
        public string CodigoTurma { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public decimal Nota3 { get; set; }


        public bool Aprovado
        {
            get
            {
                var somaDeNotas = Nota1 + Nota2 + Nota3;
                return somaDeNotas == 0 ? false : somaDeNotas / 3 >= 6;
            }
        }
    }
}
