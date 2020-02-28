using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramacao.Models
{
    public class Aluno
    {
        public List<Turma> Turmas { get; set; } 

        public decimal Mensalidade { get; set; }

        public List<Notas> MinhasNotas { get; set; }


    }
}
