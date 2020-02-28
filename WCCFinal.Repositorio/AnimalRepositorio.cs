using System;
using System.Collections.Generic;
using System.Text;
using WCCFinal.Dominio.Modelo;

namespace WCCFinal.Repositorio
{
    public class AnimalRepositorio
    {
        public  List<Animal> SelecionarTodosanimais()
        {

            public void IncluirAnimal( Animal animal)
            {
                new Conexao() .Executar(
                    "INSERT INTO ANIMAL" +
                    "(Nome, Raca, IdTipoAnimal, Porte" +
                    "DataNasc, Femea) VALEUS" +
                    $"('{animal.Nome}', " +
                    $"{animal.Raca})'," +
                    $"2" +
                    $"{animal.Porte}"
                    )


            }
            var dt = new Conexao().Consulta("select * from Animal");

            List<Animal> lst = new List<Animal>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Animal a = new Animal
                {
                    DataNasc = Convert.ToDateTime(dt.Rows[i]["DataNasc"].ToString()),
                    Femea = Convert.ToBoolean(dt.Rows[i]["Femea"]),
                    Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Porte = dt.Rows[i]["Porte"].ToString(),
                    Raca = dt.Rows[i]["Raca"].ToString()
                };
                a.MeuTipoAnimal.Id = Convert.ToInt32(dt.Rows[i]["idTipoAnimal"]);

                lst.Add(a);

            }

            return new List<Animal>();
        }
    }
}
