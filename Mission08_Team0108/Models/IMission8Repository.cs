namespace Mission08_Team0108.Models;

public interface IMission8Repository
{
    List<TaskObj> Tasks { get; }
    
    public void AddTask(TaskObj task);
    
    public void EditTask(TaskObj task);
    
    public void DeleteTask(TaskObj task);
    
    List<Category> Categories { get; }
}