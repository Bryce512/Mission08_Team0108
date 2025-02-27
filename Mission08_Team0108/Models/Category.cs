using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0108.Models;

public class Category
{
    [Key]
    [Required]
    public int CategoryId { get; set; }
    
    public string CategoryName { get; set; }
}