using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    public class Crush
    {
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Local { get; set; }
        public EstadoCivil EstadoCivilCrush { get; set; }
        public int Avaliacao { get; set; }
        public List<Comportamento> Comportamentos { get; set; }

        private  int PropriedadePrivada { get; set; }

        public Comportamento Comportamento { get; set; }
    }

    public void BeijosNoBoy(int nivelDeSaudade)
    {
        bool darBeijoNoBoy = false;
        for (int 1 = 0; i < nivelDeSaudade; int ++)
        {
            darBeijoNoBoy = true;
        }
    }


    public enum EstadoCivil
    {
        Solteiro,
        Namorando, 
        Noivo,
        Casado,
        Divorciado,
        Viuvo
    }

    public void teste()
    {
        ProoriedadePrivatda
    }
}
