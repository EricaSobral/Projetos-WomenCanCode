using AgendaTelefonica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Repositorio
{
    public class ContatoRepositorio
    {
        private List<Contato> Contatos;
        private void CriarDados()
        {
            Contatos = new List<Contato>();

            Contatos.Add(new Contato(1,"Thamirys", "11 9988-6655", "thamiris@gmail.com"));

            Contatos.Add(new Contato(2,"Alexia", "11 97474 - 6464", "Aleevitoria@gmail.com", apelido: "Irmão da Alexia(solteiro)"));

            Contatos.Add(new Contato(3,"Thalita", "11 95245-3433", "thalita@gmail.com", apelido: "cunhado da alexia"));
            
        }

        public ContatoRepositorio()
        {
            CriarDados();
        }

        public List<Contato> SelecionarTodos()
        {
            return Contatos.OrderBy(t => t.Nome).ToList();
        }

        public Contato BuscarContato(int id)
        {
            return Contatos.FirstOrDefault(t => t.Id == id);
        }
    }
}
