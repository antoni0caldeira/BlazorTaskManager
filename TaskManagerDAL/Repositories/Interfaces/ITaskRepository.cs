using System.Collections.Generic;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Models.Task> GetAll();
    }
}
