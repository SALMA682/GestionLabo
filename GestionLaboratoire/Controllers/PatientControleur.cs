using GestionLaboratoire.Data;
using GestionLaboratoire.Models;
using Microsoft.AspNetCore.Mvc;

public class PatientController : Controller
{
    private readonly ApplicationDbContext _context;

    public PatientController(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IActionResult AfficherPatient()
    {
        var patients = _context.Patients.ToList();
        return View(patients);
    }
    

}
