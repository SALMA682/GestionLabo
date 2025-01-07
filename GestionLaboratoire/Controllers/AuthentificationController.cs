using Microsoft.AspNetCore.Mvc;

namespace GestionLaboratoire.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
