using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAspNetApp.Models;

namespace MyAspNetApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        ViewBag.IsLoggedIn = true;
        ViewBag.Name = "Ivan";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {

        ViewBag.Message = "Здравей, Ивелин!";
        return View();
    }

    public IActionResult Categories()
    {
        var categories = new List<string> { "Яйца", "Мляко", "Месо", "Зеленчуци" };
        return View(categories);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
