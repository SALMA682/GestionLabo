using Microsoft.AspNetCore.Mvc;
using GestionLaboratoire.Data;
using GestionLaboratoire.Models;
using System.Linq;

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
            var patient = _context.Patients.ToList();
            return View(patient);
        }
    }
}