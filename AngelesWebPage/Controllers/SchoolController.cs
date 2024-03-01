using AngelesWebPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace AngelesWebPage.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Schedule()
        {
            ViewData["Schedule"] = "Saturday | 01:00 PM - 04:00 PM";
            return View();
        }
    }
}
