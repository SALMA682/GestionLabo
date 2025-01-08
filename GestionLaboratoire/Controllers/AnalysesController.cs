using GestionLaboratoire.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestionLaboratoire.Controllers
{
    public class AnalysesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnalysesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var analyses = _context.Analyses.ToList();  // Récupère les données de la table Analyses
            if (analyses == null || !analyses.Any())
            {
                return NotFound();
            }
            return View(analyses);  // Passe les données à la vue
        }
    }
    
    /*public IActionResult Index()
        {
            return View();
        }
    }*/
}
