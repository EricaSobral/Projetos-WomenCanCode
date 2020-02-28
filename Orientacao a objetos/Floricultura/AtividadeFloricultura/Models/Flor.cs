using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeFloricultura.Models
{
    public class Flor
    {
        public Guid  Id { get; set; }

        public string Especie { get; set; }

        public string Descricao { get; set; }

        public string Cor { get; set; }

        public double Preco { get; set; }
    
        public Flor()
    {
      Id = Guid.NewGuid();
    }
   
    }

}
