using Kalevich.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kalevich.UI.Controllers
{
    public class HomeController : Controller 
{ 
    private readonly ILogger<HomeController> _logger; 
    private readonly List<ListDemo> _listData;
    private readonly List<Book>? books;

        public HomeController(ILogger<HomeController> logger) 
    { 
        _logger = logger;

        books = new List<Book>    
        {
        new Book{ BookId=1, Name="Book1", Author="Author1"},
        new Book{ BookId=2, Name="Book2", Author="Author2"},
        new Book{ BookId=3, Name="Book2", Author="Author3"}
        };

            _listData = new List<ListDemo> 
        { 
            new ListDemo {Id=1, Name="Item 1"}, 
            new ListDemo {Id=2, Name="Item 2"}, 
            new ListDemo {Id=3, Name="Item 3"} 
        }; 
    } 
 
    public IActionResult Index() 
    {
        //ViewData["booksList"] = books; 
        ViewData["text"] = "Лабораторная работа №2";
        ViewData["Lst"] = new SelectList(_listData, "Id", "Name");
        return View(books); 
    }         
} 
 
public class ListDemo 
{ 
    public int Id { get; set; } 
    public string? Name { get; set; } 
} 
}
