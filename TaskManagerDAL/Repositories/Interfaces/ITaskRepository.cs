using System;
using System.Collections.Generic;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface ITaskRepository : IRepository<Task>
    {
        IEnumerable<Task> GetByFilters(int status, DateTimeOffset starDate, DateTimeOffset endDate);
    }
}
