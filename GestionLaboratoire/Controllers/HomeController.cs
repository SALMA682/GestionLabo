using AspNetCore;
using GestionLaboratoire.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestionLaboratoire.Controllers
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
        public IActionResult AccueilAdministrateur()
        {
            return View();
        }
        public IActionResult AccueilPreleveur()
        {
            return View();
        }
        public IActionResult AccueilAssistant()
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
