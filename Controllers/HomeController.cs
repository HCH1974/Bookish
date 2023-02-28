using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

  
    [Route("my-route")]    
    public IActionResult Privacy()
    {
        return View("Privacy");
    }

    public IActionResult Members()
    {
        return View();
    }

    // public IActionResult Books()
    // {
    //     return View(new Books("Harry Potter", "JK Rowling",10, 15));
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
