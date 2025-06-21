using Kalevich.UI.Models;
using Microsoft.AspNetCore.Mvc;
namespace Kalevich.UI.Components
{
    public class RowViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Book book)
        {
            return View(book);
        }
    }
}
