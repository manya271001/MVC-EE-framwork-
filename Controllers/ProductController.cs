using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["msg"] = "Welcome";
            return View();
        }
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Product _product)
        {
             Product p1= new Product();
            p1.Name = "laptop";
            p1.Price = 100;
            return View(p1);
        }
    }

}
