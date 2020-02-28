using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramacao.Models
{
    public class Professor : Pessoa
    {
        public Graduacao MinhaGraduacao { get; set; }

        public List<Materia> TipoAula { get; set; }

        public decimal Salario { get; set; }

        public List<Turno> TurnoDisponiveis { get; set; }
    }
    public enum Graduacao
    {
        Graduado,
        PosGraduado,
        Mestrado,
        Doutorado,
        PhD

    }
}
