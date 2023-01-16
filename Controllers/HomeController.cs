using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Servicios;
using System.ComponentModel;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Proyecto> _proyectos;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            _proyectos = repositorioProyectos.proyectos;
        }

        public IActionResult Index()
        {
            var modelo = new HomeIndexViewModel() { Proyectos = this._proyectos };
            return View(modelo);
        }

      

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}