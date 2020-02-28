using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDeProgramacao.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string  CPf { get; set; }

        public string Email { get; set; }

        public Endereco MeuEndereco { get; set; }
    }
}
