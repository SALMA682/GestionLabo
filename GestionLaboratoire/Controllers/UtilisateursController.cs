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
        public IActionResult IndexModification()
        {
            var analyses = _context.Analyses.ToList();  // Récupère les données de la table Analyses
            if (analyses == null || !analyses.Any())
            {
                return NotFound();
            }
            return View(analyses);  // Passe les données à la vue
        }

        [HttpGet]
        public IActionResult ModifierAnalyse(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Analyses? CatDb = _context.Analyses.Find(id);
            if (CatDb == null)
            {
                return NotFound();
            }
            return View(CatDb);
        }

        [HttpPost]
        public IActionResult ModifierAnalyse(Analyses obj)
        {
            if (ModelState.IsValid)
            {
                _context.Analyses.Update(obj);
                _context.SaveChanges();
                TempData["succes"] = "L'opération de Modification est réussie";
                return RedirectToAction("Index", "Analyses");
            }
            TempData["echec"] = "L'opération de modification a Echoué";
            return View();
        }
        public IActionResult IndexSupprimer()
        {
            var analyses = _context.Analyses.ToList();  // Récupère les données de la table Analyses
            if (analyses == null || !analyses.Any())
            {
                return NotFound();
            }
            return View(analyses);
        }

        public IActionResult SupprimerAnalyse(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Analyses? CatDb = _context.Analyses.Find(id);
            if (CatDb == null)
            {
                return NotFound();
            }
            return View(CatDb);

        }
        [HttpPost, ActionName("Supprimer")]
        public IActionResult SupprimerPost(int? id)
        {
            Analyses? obj = _context.Analyses.Find(id);
            if (obj == null)
            {
                TempData["echec"] = "L'opération de Suppression a Echoué";
                return NotFound();
            }
            TempData["succes"] = "L'opération de Suppression est réussie";
            _context.Analyses.Remove(obj);
            _context.SaveChanges();

            return RedirectToAction("Index", "Analyses");
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
        //Ajouter patient
        
        public IActionResult  AjouterPatient()
		{
			// Logique pour Ajouter un Patient
			return View();
		}








        // supprimer patient
      
        public IActionResult SupprimerPatient()
		{
			// Logique pour supprimer un patient
			return View();
		}
        // Modifier patient
        
        public IActionResult ModifierPatient()
		{
			// Logique pour Modifier un patient
			return View();
		}

        [HttpPost]
        public IActionResult AjouterEchantillon(Echantillon obj)
        {
            if (ModelState.IsValid)
            {
                _context.Echantillons.Add(obj);
                _context.SaveChanges();
                TempData["succes"] = "L'opération de l'ajout est réussie";
                return RedirectToAction("Index", "Analyses");
            }
            TempData["echec"] = "L'opération d'ajout a Echoué";
            return View();
        }





    }
}
