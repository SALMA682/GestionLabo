using Microsoft.AspNetCore.Mvc;

namespace GestionLaboratoire.Controllers
{
    public class InformationsController : Controller
    {
        public IActionResult Informations()
        {
            return View();
        }
    }
}
