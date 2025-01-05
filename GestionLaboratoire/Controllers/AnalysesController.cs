using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionLaboratoire.Models;
using Microsoft.EntityFrameworkCore;
using GestionLaboratoire.Data;


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

      /*  // GET: AnalysesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnalysesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnalysesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnalysesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnalysesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnalysesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnalysesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }*/
}

