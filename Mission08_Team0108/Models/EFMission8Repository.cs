using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0108.Models;

public class EFMission8Repository : IMission8Repository
{
    private readonly Mission8Context _context;
    
    public EFMission8Repository(Mission8Context temp)
    {
        _context = temp;
    }
    
    public List<TaskObj> Tasks => _context.Tasks.ToList();
    
    public void AddTask(TaskObj task)
    {
        _context.Add(task);
        _context.SaveChanges();
    }

    public void EditTask(TaskObj task)
    {
        _context.Tasks.Update(task);
        _context.SaveChanges();
    }

    public void DeleteTask(TaskObj task)
    {
        _context.Remove(task);
        _context.SaveChanges();
    }

    public IEnumerable<TaskObj> GetTaskWithCategories()
    {
        return _context.Tasks.Include(t => t.Category).ToList();
    }

    public List<Category> Categories => _context.Categories.ToList();
}