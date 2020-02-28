using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    public class Comportamento
    {
        public string Descricao { get; set; }
        public int Intensidade { get; set; }


        public void IncluirIntensidade(int intensidade)
        {
            Intensidade += intensidade;
        }

        public void DiminuirIntensidade(int intensidade)
        {
            Intensidade -= intensidade;
        }

        public static implicit operator Comportamento(List<Comportamento> v)
        {
            throw new NotImplementedException();
        }
    }
}
