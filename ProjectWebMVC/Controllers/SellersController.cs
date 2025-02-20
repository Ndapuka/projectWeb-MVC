using Microsoft.AspNetCore.Mvc;
using ProjectWebMVC.Data;
using ProjectWebMVC.Services;

namespace ProjectWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController (SellerService sellerService) 
        {
            _sellerService= sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
