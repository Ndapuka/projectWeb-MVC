using Microsoft.AspNetCore.Mvc;
using ProjectWebMVC.Models;
using ProjectWebMVC.Models.ViewModels;
using System.Diagnostics;

namespace ProjectWebMVC.Controllers
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
            ViewData["Name"] = "Moises Ndapuka Maquina";
            ViewData["Message"] = "all about the privacy politic";
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
