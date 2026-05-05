using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreCrudApp.Models;
using AspNetCoreCrudApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCrudApp.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        // Ensure database is created
        await _context.Database.EnsureCreatedAsync();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
