using Microsoft.AspNetCore.Mvc;
using PortFol.Models;
using PortFol.Resources;
using System.Diagnostics;

namespace PortFol.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // El Helper ensambla la lista de mensajes del .resx.
            List<string> introMessages = UIHelper.GetIntroSequenceMessages();

            // Enviamos la lista de mensajes a la vista como nuestro Modelo.
            return View(introMessages);
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
