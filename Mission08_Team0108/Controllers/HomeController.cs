using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Mission08_Team0108.Models;

namespace Mission08_Team0108.Controllers;

// private TaskContext _context;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

// Constructor with Task Context    
    // public HomeController(TaskContext temp)
    // {
    //     _context = temp;
    // }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    
    public IActionResult Quadrants()
    {
        // ViewBag.Categories = _context.Categories.ToList();
        // var taskList = _context.Tasks.ToList();
        //     Where(Completed != True)
        //     orderby(Description Ascending = True);
        // return View(taskList);
        return View();
    }

    public IActionResult AddTask()
    {

        return View();
    }

    [HttpGet]
    public IActionResult EditTask()
    {
        // Task task = _context.Tasks
        //     .Single(x => x.taskID == taskId)
        // return View("AddTask", task);
        return View("AddTask");
    }

    [HttpPost]
    public IActionResult EditTask(Task updatedTask)
    {
        // _context.Tasks.update(updatedTask);
        // _context.SaveChanges();
        return RedirectToAction("Quadrants");
    }

    [HttpPost]
    public IActionResult DeleteTask(int id)
    {
        // var taskToDelete = _context.Tasks
        //     .Single(x => x.taskId == id);
        // _context.Tasks.Remove(taskToDelete);
        // _context.SaveChanges();
        
        return RedirectToAction("Quadrants");
    }
}