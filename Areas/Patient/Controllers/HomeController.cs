using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        [Area("Patient")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
