using AtividadeFloricultura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeFloricultura.Repositorio
{
    public class FlorRepositorio
    {
        private List<Flor> _flores;

        public FlorRepositorio (List<Flor> floresGuardadas)
        {
            _flores = floresGuardadas;
        }
        public void Adicionar (Flor flor)
        {
            _flores.Add(flor);
        }

        public List <Flor> Listar()
        {
            return _flores;
        }

        public Flor Obter (string id)
        {
            // Quando digitar o Where, você vai precisar dar Ctrl
            // para adicionar o using System.Linq

            var flor = _flores.Where(x => x.Id.ToString() == id)
                .FirstOrDefault();
            return flor;
        }
    }
}
