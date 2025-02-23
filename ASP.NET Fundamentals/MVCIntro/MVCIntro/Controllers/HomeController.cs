using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MVCIntro.Controllers
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
            ViewBag.Message = "Hello World!";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET Core MVC app.";
            ViewBag.Description = "This is the About page for our first ASP.NET Core MVC app.";

            return View();
        }
        public IActionResult Numbers()
        {
            return View();
        }
        public IActionResult Numbers1ToN(int count=3)
        {
            ViewBag.Count = count;
            return View();
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
