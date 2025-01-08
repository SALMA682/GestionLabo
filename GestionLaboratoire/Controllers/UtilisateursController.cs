using GestionLaboratoire.Data;
using GestionLaboratoire.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLaboratoire.Controllers
{
    public class UtilisateursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDbContext _context; // Contexte de base de données

        public UtilisateursController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AjouterAnalyse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AjouterAnalyse(Analyses obj)
        {
            if (ModelState.IsValid)
            {
                _context.Analyses.Add(obj);
                _context.SaveChanges();
                TempData["succes"] = "L'opération de l'ajout est réussie";
                return RedirectToAction("Index", "Analyses");
            }
            TempData["echec"] = "L'opération d'ajout a Echoué";
            return View();
        }

        public IActionResult ModifierAnalyse()
        {
            // Logique pour modifier une analyse
            return View();
        }

        public IActionResult SupprimerAnalyse()
        {
            // Logique pour supprimer une analyse
            return View();
        }
        public IActionResult AjouterAssistant()
        {
            // Logique pour ajouter une analyse
            return View();
        }

        public IActionResult ModifierAssistant()
        {
            // Logique pour modifier une analyse
            return View();
        }

        public IActionResult SupprimerAssistant()
        {
            // Logique pour supprimer une analyse
            return View();
        }
        public IActionResult AjouterPreleveur()
        {
            // Logique pour ajouter une analyse
            return View();
        }

        public IActionResult ModifierPreleveur()
        {
            // Logique pour modifier une analyse
            return View();
        }

        public IActionResult SupprimerPreleveur()
        {
            // Logique pour supprimer une analyse
            return View();
        }

    }
}
