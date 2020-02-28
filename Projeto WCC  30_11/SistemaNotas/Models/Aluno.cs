using SistemaNotas.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Models
{
    public class Aluno 
    {
        public Aluno(int ra, string nome, string turma, Notas notasauluno = null, Frequencia fequencialuno = null)
        {
            Ra = ra;
            Nome = nome;
            Turma = turma;
        }

    
        public int Ra {get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }
        public Frequencia FrequenciAluno { get; set; }
        public Notas NotasAlunos { get; set; }

        

    }




}
