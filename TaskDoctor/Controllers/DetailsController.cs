using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using TaskDoctor.Data;
using TaskDoctor.Models;

namespace TaskDoctor.Controllers
{
    public class DetailsController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var doctors = dbContext.Doctors.ToList();
            return View(doctors);
}
        public IActionResult AddPatient(Patient patient)
        {
            

            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();
           
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id)
        {
            var   doctor = dbContext.Doctors.Find(id);
            return View(doctor);
        }
    }
}
