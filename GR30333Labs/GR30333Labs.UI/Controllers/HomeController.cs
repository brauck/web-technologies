using Microsoft.AspNetCore.Mvc;

namespace GR30333Labs.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
