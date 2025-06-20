using Microsoft.AspNetCore.Mvc;

namespace Kalevich.UI.wwwroot.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            retun View();
        }
    }
}
