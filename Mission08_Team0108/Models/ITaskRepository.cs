namespace Mission08_Team0108.Models;

public interface ITaskRepository
{
    List<TaskObj> Tasks { get; }
    List<Category> Categories { get; }
    
    public void AddTask(TaskObj task);
    
    public void UpdateTask(TaskObj task);
    
    public void DeleteTask(int Id);
}