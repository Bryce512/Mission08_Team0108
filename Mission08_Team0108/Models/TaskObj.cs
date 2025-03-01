using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0108.Models;

public class TaskObj
{
    [Key]
    [Required]
    public int TaskId { get; set; }
    
    [Required]
    public string TaskName { get; set; }
    
    public DateTime? DueDate { get; set; }
    
    [Required]
    public int Quadrant { get; set; }
    
    [ForeignKey("CategoryId")]
    [Required]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    
    public bool? IsCompleted { get; set; }
}