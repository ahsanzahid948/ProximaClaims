using Microsoft.AspNetCore.Mvc;
using ProximaClaims.HelperModels;
using ProximaClaims.Models;
using ProximaClaims.Services;

namespace ProximaClaims.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailService _mailService;

        public HomeController(ILogger<HomeController> logger, IMailService mailService)
        {
            _logger = logger;
            _mailService= mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public async Task<IActionResult> SaveContact(Contact contact)
        {
            try
            {
               
                await _mailService.SendEmailAsync(contact);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
            
        }
        public IActionResult MedicalBiling()
        {
            return RedirectToAction("Index");
        }
    }
}