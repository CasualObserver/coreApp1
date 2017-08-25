using System.Threading.Tasks;
using CoreApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "The House of Kobe"};          
            return new ObjectResult(model);
        }
    }
}
