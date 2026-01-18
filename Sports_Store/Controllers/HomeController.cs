using Microsoft.AspNetCore.Mvc;

namespace Sports_Store.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}