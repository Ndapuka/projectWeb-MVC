using Microsoft.AspNetCore.Mvc;

namespace ProjectWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
