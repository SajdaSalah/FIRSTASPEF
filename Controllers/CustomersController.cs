using FIRSTASPEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIRSTASPEF.Controllers
{
    public class CustomersController: Controller
    {
        public IActionResult Index()
        {
            IList<Customers> customer = new List<Customers>
        {
            new Customers { Id = 1, Name = "sajda", Email = "sajda@gmail.com" },
            new Customers { Id = 2, Name = "linda", Email ="linda@gmail.com" },
            new Customers { Id = 3, Name = " mohamed", Email = "mohamed@gmail.com" }
        };

            return View(customer);
        }
           
        }
    }

