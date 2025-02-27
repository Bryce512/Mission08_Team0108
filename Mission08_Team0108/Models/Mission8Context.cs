using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0108.Models;

public class Mission8Context : DbContext
{
    public Mission8Context(DbContextOptions<Mission8Context> options) : base(options)
    {
    }
    
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Category> Categories { get; set; }
}