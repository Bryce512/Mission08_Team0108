using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Mission08_Team0108.Models;

namespace Mission08_Team0108.Controllers;

public class HomeController : Controller
{
    private Mission8Context _context;
    
// Constructor with Task Context    
    public HomeController(Mission8Context temp)
    {
        _context = temp;
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
        ViewBag.Categories = _context.Categories.ToList();
        var taskList = _context.Tasks
            .Where(x => x.IsCompleted != true)
            .OrderBy( x => x.TaskName)
            .ToList();
        return View(taskList);
    }

    [HttpGet]
    public IActionResult AddTask()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddTask(TaskObj response)
    {
        _context.Tasks.Add(response);
        _context.SaveChanges();
        return RedirectToAction("Quadrants");
    }

    [HttpGet]
    public IActionResult EditTask(int taskId)
    {
        TaskObj task = _context.Tasks
            .Single(x => x.TaskId == taskId);
        return View("AddTask", task);
    }

    [HttpPost]
    public IActionResult EditTask(TaskObj updatedTask)
    {
        _context.Tasks.Update(updatedTask);
        _context.SaveChanges();
        return RedirectToAction("Quadrants");
    }

    [HttpPost]
    public IActionResult DeleteTask(int id)
    {
        var taskToDelete = _context.Tasks
            .Single(x => x.TaskId == id);
        _context.Tasks.Remove(taskToDelete);
        _context.SaveChanges();
        
        return RedirectToAction("Quadrants");
    }
}