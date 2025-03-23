# TaskFlow API  

## Description  
The TaskFlow API is a RESTful service built with ASP.NET Core Web API that allows users to manage their tasks efficiently. It follows a modern architectural pattern, implementing the **Repository Pattern**, **Unit of Work**, and **Base Model** to improve maintainability and scalability. The API provides functionalities to create, update, delete, and retrieve tasks stored in a SQL Server database.  

---  

## Technologies Used  
- **ASP.NET Core** (or your current version)  
- **Entity Framework Core**  
- **SQL Server**  
- **Swagger (OpenAPI)** for API documentation  
- **Repository Pattern**  
- **Unit of Work Pattern**  
- **Base Model Inheritance**  

---  

## Architectural Patterns  

### Repository Pattern  
A design layer that abstracts database operations (e.g., CRUD) into reusable components. It decouples business logic from direct data access, improving testability and reducing redundancy.  

**Example Implementation**:  
```csharp
public interface ITaskRepository 
{
    Task<TaskItem> GetByIdAsync(Guid id);
    Task<IEnumerable<TaskItem>> GetAllAsync();
    void Add(TaskItem task);
    void Update(TaskItem task);
    void Delete(TaskItem task);
}
```  

---

### Unit of Work Pattern  
The **Unit of Work** pattern ensures that multiple operations related to a single transaction are executed together. It maintains a single database context throughout a business operation, preventing partial updates and improving performance.  

**Example Implementation**:  
```csharp
public interface IUnitOfWork : IDisposable
{
    ITaskRepository Tasks { get; }
    Task<int> CompleteAsync();
}
```  

---

### Base Model  
The **Base Model** provides common properties such as `Id`, `CreatedAt`, and `UpdatedAt` to maintain consistency across all entities. It ensures uniformity and reduces code duplication.  

**Example Implementation**:  
```csharp
public abstract class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
```  

---  

## Features  
- Add new tasks  
- Retrieve all tasks  
- Get a specific task by ID  
- Update an existing task  
- Delete a task  

---

## API Endpoints  

### Task Endpoints  
| Method | Endpoint         | Description             |  
|--------|-----------------|-------------------------|  
| GET    | /api/tasks      | Retrieve all tasks      |  
| GET    | /api/tasks/{id} | Get a task by ID        |  
| POST   | /api/tasks      | Create a new task       |  
| PUT    | /api/tasks/{id} | Update an existing task |  
| DELETE | /api/tasks/{id} | Delete a task           |  

---  

## License  
This project is licensed under the MIT License. See the LICENSE file for more details.
