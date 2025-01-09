using GestionLaboratoire.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestionLaboratoire.Controllers
{
    public class PatientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var patient = _context.Patients.ToList();  // Récupère les données de la table Patient
            if (patient == null || !patient.Any())
            {
                return NotFound();
            }
            return View(patient);  // Passe les données à la vue
        }
    }

    /*public IActionResult Index()
        {
            return View();
        }
    }*/
}
