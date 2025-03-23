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

## Features  
- Add new tasks  
- Retrieve all tasks  
- Get a specific task by ID  
- Update an existing task  
- Delete a task  

---

## API Endpoints  
### Task Endpoints  
| Method | Endpoint           | Description                      |  
|--------|--------------------|----------------------------------|  
| GET    | `/api/tasks`       | Retrieve all tasks              |  
| GET    | `/api/tasks/{id}`  | Get a task by ID                |  
| POST   | `/api/tasks`       | Create a new task               |  
| PUT    | `/api/tasks/{id}`  | Update an existing task         |  
| DELETE | `/api/tasks/{id}`  | Delete a task                   |  

---

## License  
This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.  
