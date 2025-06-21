using Microsoft.AspNetCore.Mvc;

namespace Kalevich.UI.Components
{
    public class CartViewComponent : ViewComponent
    {
        double summary = 0;
        int quantity = 0;

        public IViewComponentResult Invoke()
        {
            ViewData["summary"] =  summary;
            ViewData["quantity"] = quantity;
            return View();
        }

    }
}
