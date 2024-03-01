using AngelesWebPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AngelesWebPage.Controllers
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
            ViewData["Name"] = "Aaron Michael M. Angeles";
            ViewData["Course"] = "Bachelor of Science in Information Technology";
            ViewData["Section"] = "32E3";
            return View();
        }

        public IActionResult School()
        {
            ViewData["Schedule"] = "Saturday | 01:00 PM - 04:00 PM";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
