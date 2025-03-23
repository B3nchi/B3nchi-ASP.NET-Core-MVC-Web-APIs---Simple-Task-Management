namespace TaskFlow.API.Models;

public class TaskItem : BaseModel
{
   
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool isCompleted { get; set; }
    
}