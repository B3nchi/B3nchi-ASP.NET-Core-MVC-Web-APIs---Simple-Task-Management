using TaskFlow.API.Models;
using System.Threading.Tasks;

namespace TaskFlow.API.Repositories;

public interface ITaskRepository : IGenericRepository<TaskItem>
{
}