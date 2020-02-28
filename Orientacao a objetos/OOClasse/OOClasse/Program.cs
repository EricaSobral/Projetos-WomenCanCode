using Crushs;
using System;
using System.Collections.Generic;

namespace OOClasse
{
    class Program
    {
        static void Main(string[] args)
         {
            Crush crush = new Crush ();

            crush.Avaliacao = 3;
            crush.Apelido = "Japinha";
            
            crush.Comportamento = new List<Comportamento>();

            Comportamento feliz = new Comportamento();
            
            // Instanciando a classe cSharp que herda de pessoa
            Programador cSharp = new Programador(9, true);



            Pessoa pessoa = new Pessoa();

            cSharp.AnosCarreira = 0;

            cSharp.Linguagens = new List<string>();
            cSharp.Linguagens.Add("C#");
            cSharp.Linguagens.Add("Java");

            cSharp.PossuiGraduacao = true;
            cSharp.Salario = 2000;
            cSharp.TrabalhaNaArea = true;

            cSharp.Idade = 24;
            cSharp.Nome = "Erica";
            cSharp.NomedaMae = "Marcia";

            cSharp.Endereco = new Endereco();
            cSharp.Endereco.Bairro = "Ipiranga";
            cSharp.Endereco.Cidade = "São Paulo";
            cSharp.Endereco.Estado = "SP";

            Console.WriteLine();
        }
    }
}
