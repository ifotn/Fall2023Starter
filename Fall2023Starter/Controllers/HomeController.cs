using Fall2023Starter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fall2023Starter.Controllers
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

        public IActionResult Privacy()
        {
            var x = 123;

            return View();
        }

        public IActionResult About() 
        {
            // set a var and pass to the view using the ViewData key / value dictionary
            ViewData["CurrentDateTime"] = DateTime.Now;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}