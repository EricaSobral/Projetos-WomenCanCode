using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Models
{
    public class Notas

    {
        public double Nota1 { get; set; } 

        public double Nota2 { get; set; }

        public double Nota3 { get; set; }

        public double Nota4 { get; set; }

       
       public string VericarNulo(Notas notas)
        {
            double? nota1 = Nota1;
            double? nota2 = Nota2;
            double? nota3 = Nota3;
            double? nota4 = Nota4;
           ;
           
            double? nulo = (nota1 + nota2 + nota3 + nota4);

            if (nulo != null)
            {
                return "Pendente";
            }
            else
            {
                return "insira o valor da nota";
            }


        }
    }

   
}
