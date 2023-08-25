using Microsoft.AspNetCore.Mvc;

namespace ProximaClaims.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult MedicalBiling()
        {
            return View();
        }
        public IActionResult MedicalCoding()
        {
            return View();
        }
    }
    
}
