using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeFloricultura.Models;
using AtividadeFloricultura.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeFloricultura.Controllers
{
    public class FloresController : Controller
    {
        private FlorRepositorio _repositorio;

        public FloresController(List<Flor> flores)
        {
            _repositorio = new FlorRepositorio(flores);
        }

        public IActionResult Index()
        {
            var flores = _repositorio.Listar();
            return View(flores);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Flor flor)
        {
            _repositorio.Adicionar(flor);
            return RedirectToAction(nameof(Index));
        }

        [Route("Flores/Detalhes/{id}")]
        public IActionResult Detalhes(string id)
        {
            Flor flor = _repositorio.Obter(id);

            return View(flor);
        }
    }
}