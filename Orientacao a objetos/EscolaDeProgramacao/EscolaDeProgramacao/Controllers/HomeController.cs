using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EscolaDeProgramacao.Models;

namespace EscolaDeProgramacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [Route ("materia")]
        public IActionResult Materia()
        {
            List<Materia> materia = new List<Materia>();
            materia.Add(new Materia(){
                Nome = "React",
                Descricao = "Desenvolvimento Web"
            });

            materia.Add(new Materia()
            {
                Nome = "C#"
            });
            return View("Views/Home/Paginas/Materia.cshtml", materia);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
