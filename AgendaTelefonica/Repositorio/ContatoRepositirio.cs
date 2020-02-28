using AgendaTelefonica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Repositorio
{
    public class ContatoRepositirio
    {
        private List<Contato> Contatos;


        private void CriaDados()
        {

            Contatos = new List<Contato>();
            Contatos.Add(new Contato(
                1,
                "Thamy",
                "123456789",
                "thamy@email.com"));
            Contatos.Add(new Contato(
                2,
                "Ale",
                "987654321",
                "ale@email.com",
                apelido: "irmão da Aléxia"));
            Contatos.Add(new Contato(
                3,
                "Sei lá",
                "123456543",
                "blabla@email.com"));
        }

        public ContatoRepositirio()
        {
            CriaDados();
        }

        public List<Contato> SelecionarTodos()
        {
            return Contatos.OrderBy(t => t.Nome).ToList();
        }

        public Contato BuscarContato(int id)
        {
            return Contatos.FirstOrDefault(t => t.Id == id);
        }
    
        public void IncluirContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public void EditarContato(Contato contato)
        {
            var meuContato = BuscarContato(contato.Id);
            int indice = Contatos.IndexOf(meuContato);
            Contatos[indice] = contato; 
        }

        public void ExcluirContato(int id)
        {
                Contatos.Remove(BuscarContato(id));
        }

    }
}

