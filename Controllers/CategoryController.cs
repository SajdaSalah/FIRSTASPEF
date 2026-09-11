using FIRSTASPEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIRSTASPEF.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            IList<Categories> category = new List<Categories>
        {
            new Categories { Id = 1, Name = "Computers", Description = "Desktop and laptop computers" },
            new Categories { Id = 2, Name = "Monitors", Description ="Hight resolution computer screens" },
            new Categories { Id = 3, Name = " Networking", Description = "Networking" }
        };

            return View(category);
        }
    }
}

    
        
           



