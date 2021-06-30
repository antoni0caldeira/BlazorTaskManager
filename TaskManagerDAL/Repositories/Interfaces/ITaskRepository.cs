using System.Collections.Generic;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Models.Task> GetAll();
        Task GetTaskById(int taskId);
    }
}
