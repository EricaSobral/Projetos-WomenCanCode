using AgendaTelefonica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Models
{
    public class Contato
    {
        public Contato(int id,string nome, string celular, 
            string email,   string comercial = null, string fixo = null, string apelido = null)
        {
            Id = id;
            Nome = nome;
            Celular = celular;
            Email = email;
            Comercial = comercial ?? string.Empty;
            Fixo = fixo ?? string.Empty;
            Apelido = apelido ?? string.Empty; 
            // A interrogação serve apenas para quando o parametro é nulo
        }
        public Contato()
        {

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
            return new ContatoRepositorio()
                .SelecionarTodos();
        }

        public Contato BuscarContato(int id)
        {
            return new ContatoRepositorio()
                .BuscarContato(id);
        }
    }
}
