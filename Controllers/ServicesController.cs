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
        public IActionResult AccountReceivable()
        {
            return View();
        }
        public IActionResult CredentialingEnrollment()
        {
            return View();
        }
        
    }
    
}
