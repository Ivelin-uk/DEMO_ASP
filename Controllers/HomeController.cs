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

    public IActionResult Products()
    { 
        var products = new List<Product>
        {
            new Product { Name = "Яйца", Price = 4.50m },
            new Product { Name = "Месо", Price = 12.00m },
            new Product { Name = "Месо", Price = 12.00m }
        };

        return View(products);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
