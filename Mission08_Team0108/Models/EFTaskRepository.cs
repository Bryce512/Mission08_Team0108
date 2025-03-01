namespace Mission08_Team0108.Models;

public class EfTaskRepository : ITaskRepository
{
    
    private Mission8Context _context;
    
// Constructor with Task Context    
    public EfTaskRepository(Mission8Context temp)
    {
        _context = temp;
    }
    
    public List<TaskObj> Tasks => _context.Tasks.ToList();
    public List<Category> Categories => _context.Categories.ToList();
    public void AddTask(TaskObj task)
    {
        _context.Tasks.Add(task);
        _context.SaveChanges();
    }

    public void UpdateTask(TaskObj task)
    {
        _context.Tasks.Update(task);
        _context.SaveChanges();
    }

    public void DeleteTask(int Id)
    {
        var taskToDelete = _context.Tasks
            .Single(x => x.TaskId == Id);
        _context.Tasks.Remove(taskToDelete);
        _context.SaveChanges();    }
}