using GestionLaboratoire.Data;
using Microsoft.AspNetCore.Mvc;


namespace GestionLaboratoire.Controllers
{
    public class AuthentificationController : Controller
    {
        private readonly ApplicationDbContext _context; // Contexte de base de données

        public AuthentificationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string nomUtilisateur, string motDePasse)
        {
            // Vérifier si l'utilisateur existe dans la base de données
            var utilisateur = _context.Utilisateurs
                .FirstOrDefault(u => u.Nom == nomUtilisateur && u.MotDePasse == motDePasse);

            if (utilisateur != null)
            {
                // Rediriger selon le rôle
                switch (utilisateur.Role)
                {
                    case "Administrateur":
                        return RedirectToAction("AccueilAdministrateur", "Home");
                    case "Preleveur":
                        return RedirectToAction("AccueilPreleveur", "Home");
                    case "Assistant":
                        return RedirectToAction("AccueilAssistant", "Home");
                    default:
                        TempData["Error"] = "Rôle non reconnu.";
                        break;
                }
            }
            else
            {
                TempData["Error"] = "Nom d'utilisateur ou mot de passe incorrect.";
            }

            return View();
        }
    }
}

