using Microsoft.AspNetCore.Mvc;

namespace WebShoes.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
