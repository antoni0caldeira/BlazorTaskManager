using System.Collections.Generic;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface ITaskStatusRepository
    {
        IEnumerable<TaskStatus> GetAll();
    }
}
