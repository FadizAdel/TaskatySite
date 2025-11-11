using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var totalTasks = _context.Tasks.Count();
        var completedTasks = _context.Tasks.Count(t => t.IsCompleted);
        var pendingTasks = totalTasks - completedTasks;
        var overdueTasks = _context.Tasks.Count(t => !t.IsCompleted && t.DueDate.HasValue && t.DueDate < DateTime.Now);

        ViewBag.TotalTasks = totalTasks;
        ViewBag.CompletedTasks = completedTasks;
        ViewBag.PendingTasks = pendingTasks;
        ViewBag.OverdueTasks = overdueTasks;

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
