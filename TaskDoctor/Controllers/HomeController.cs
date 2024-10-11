using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskDoctor.Data;
using TaskDoctor.Models;

namespace TaskDoctor.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext dbContext =  new ApplicationDbContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            var doctors = dbContext.Doctors.ToList();
            return View(doctors);
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
