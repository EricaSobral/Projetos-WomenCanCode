using System;
using System.Collections.Generic;

namespace Crushs
{
    class Program
    {
        static void Main(string[] args)
        {
            Crush marido = new Crush();
            marido.Apelido = "Ninho";
            marido.Avaliacao = 8;

            marido.Comportamentos = new List<Comportamento>();
            Comportamento compEngracado = new Comportamento();
            compEngracado.Descricao = "Carinhoso";
            compEngracado.Intensidade = 5;

            compEngracado.IncluirIntensidade(2);


            Comportamento compRomantico = new Comportamento();
            compRomantico.Descricao = "Romântico";
            compRomantico.Intensidade = 10;

            compRomantico.DiminuirIntensidade(8);

            marido.Comportamentos.Add(compEngracado);
            marido.Comportamentos.Add(compRomantico);

            
        }
    }
}
