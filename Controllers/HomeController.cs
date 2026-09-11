
using FIRSTASPEF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FIRSTASPEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Getproducts()
        {
            IList<Products> products = new List<Products>
        {
            new Products { Id = 1, Name = "Laptop Dell", Price = 3500 ,Category = "Electronics", Stock = 15 },
            new Products { Id = 2, Name = "Wireless Mouse", Price = 80 , Category = "Accessories", Stock = 50 },
            new Products { Id = 3, Name = "Mechanical Keyboard", Price = 2500 , Category = "Accessories", Stock = 20 }
        };

            return Ok(products);
        }


        public IActionResult Getcategories()
        {
            IList<Categories> category = new List<Categories>
        {
            new Categories { Id = 1, Name = "Computers", Description = "Desktop and laptop computers" },
            new Categories { Id = 2, Name = "Monitors", Description ="Hight resolution computer screens" },
            new Categories { Id = 3, Name = " Networking", Description = "Networking" }
        };

            return Ok(category);
        }
        public IActionResult Getcustomers()
        {
            IList<Customers> customer = new List<Customers>
        {
            new Customers { Id = 1, Name = "sajda", Email = "sajda@gmail.com" },
            new Customers { Id = 2, Name = "linda", Email ="linda@gmail.com" },
            new Customers { Id = 3, Name = " mohamed", Email = "mohamed@gmail.com" }
        };

            return Ok(customer);
        }



        public IActionResult Index()
        {
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
