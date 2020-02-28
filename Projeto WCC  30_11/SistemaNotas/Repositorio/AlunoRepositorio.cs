using SistemaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Repositorio
{
    public class alunoRepositorio
    {
        private List<Aluno> Aluno;

        private void AdicionarDados()
        {
            Aluno = new List<Aluno>();

            Aluno.Add(new Aluno(1, "Alexia", "A"));
            Aluno.Add(new Aluno(2, "Erica", "A"));
            Aluno.Add(new Aluno(3, "Carla", "A"));

        }

    }
}
