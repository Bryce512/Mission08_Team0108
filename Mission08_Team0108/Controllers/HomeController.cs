using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Mission08_Team0108.Models;

namespace Mission08_Team0108.Controllers;

public class HomeController : Controller
{
    private ITaskRepository _repo;
    
// Constructor with Task Context    
    public HomeController(ITaskRepository temp)
    {
        _repo = temp;
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
        ViewBag.Categories = _repo.Categories.ToList();
        var taskList = _repo.Tasks
            .Where(x => x.IsCompleted != true)
            .OrderBy( x => x.TaskName)
            .ToList();
        return View(taskList);
    }

    [HttpGet]
    public IActionResult AddTask()
    {
        ViewBag.Categories = _repo.Categories.ToList();

        return View();
    }

    [HttpPost]
    public IActionResult AddTask(TaskObj response)
    {
        _repo.AddTask(response);
        return RedirectToAction("Quadrants");
    }

    [HttpGet]
    public IActionResult EditTask(int taskId)
    {
        ViewBag.Categories = _repo.Categories.ToList();

        TaskObj task = (_repo).Tasks
            .Single(x => x.TaskId == taskId);
        return View("AddTask", task);
    }

    [HttpPost]
    public IActionResult EditTask(TaskObj updatedTask)
    {
        _repo.UpdateTask(updatedTask);
        return RedirectToAction("Quadrants");
    }

    [HttpPost]
    public IActionResult DeleteTask(int id)
    {
        _repo.DeleteTask(id);
        return RedirectToAction("Quadrants");
    }
}