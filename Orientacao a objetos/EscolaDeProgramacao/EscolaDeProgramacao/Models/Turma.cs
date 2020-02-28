using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramacao.Models
{
    public class Turma
    {
        public Turno TurnoAula { get; set; }

        public string Codigo { get; set; }

        public List<Materia> MinhaMateria { get; set; }

        public Professor ProfessorDaTurma { get; set; }

        public List <Aluno> TodosOsAlunos { get; set; }
    }
}
