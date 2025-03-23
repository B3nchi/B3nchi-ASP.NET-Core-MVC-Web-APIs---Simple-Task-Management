using System;
using System.ComponentModel.DataAnnotations;

namespace TaskFlow.API.Models;

public abstract class BaseModel
{
    [Key]
    public Guid Id { get; set; }
    
    public DateTime Created { get; set; } = DateTime.Now;
    
    public DateTime? UpdatedAt { get; set; } 
}