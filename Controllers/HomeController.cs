using Microsoft.AspNetCore.Mvc;
using ProximaClaims.Models;
using System.Diagnostics;

namespace ProximaClaims.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public IActionResult SaveContact(Contact contact)
        {
            return RedirectToAction("Index");
        }

    }
}