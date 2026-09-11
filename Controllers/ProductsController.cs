using FIRSTASPEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIRSTASPEF.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            IList<Products> products = new List<Products>
        {
            new Products { Id = 1, Name = "Laptop Dell", Price = 3500 ,Category = "Electronics", Stock = 15 },
            new Products { Id = 2, Name = "Wireless Mouse", Price = 80 , Category = "Accessories", Stock = 50 },
            new Products { Id = 3, Name = "Mechanical Keyboard", Price = 2500 , Category = "Accessories", Stock = 20 }
        };



            return View(products);
        }
    }
}
