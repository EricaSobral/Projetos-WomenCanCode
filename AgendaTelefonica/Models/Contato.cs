using AgendaTelefonica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Models
{
    public class Contato
    {
        private ContatoRepositirio repo;
        public Contato(int id, string nome, string celular,
            string email, string comercial = null, 
            string fixo = null, string apelido = null)
        {
            Id = id;
            Nome = nome;
            Celular = celular;
            Email = email;
            Comercial = comercial ?? string.Empty;
            Fixo = fixo ?? string.Empty;
            Apelido = apelido ?? string.Empty;
            //o ?? verifica se o objeto está nulo, se não estuver ele passa o valor do parametro, caso nulo passa o valor string.Empty
        }
        public Contato()
        {
            repo = new ContatoRepositirio(); 
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Comercial { get; set; }
        public string Fixo { get; set; }
        public string Email { get; set; }
        public string Apelido { get; set; }

        public List<Contato> RetornarTodos()
        {
            return repo.SelecionarTodos();
        }
        public Contato BuscarContato(int id)
        {
            return repo.BuscarContato(id);
        }
        public void IncluirContato(Contato contato)
        {
            repo.IncluirContato(contato);
        }

        public void EditarContato(Contato contato)
        {
            repo.EditarContato(contato);
        }

        public void ExcluirContato(int id)
        {
            repo.ExcluirContato(id);
        }
    }

}
