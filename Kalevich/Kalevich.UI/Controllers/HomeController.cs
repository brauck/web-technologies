using Microsoft.AspNetCore.Mvc;

namespace Kalevich.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
