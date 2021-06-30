using System.Collections.Generic;
using System.Linq;
using TaskManagerDAL.Data;
using TaskManagerDAL.Models;
using TaskManagerDAL.Repositories.Interfaces;

namespace TaskManagerDAL.Repositories
{
    public class TaskStatusRepository : ITaskStatusRepository
    {
        private TaskManagerDbContext taskManagerDbContext;

        public TaskStatusRepository(TaskManagerDbContext taskManagerDbContext)
        {
            this.taskManagerDbContext = taskManagerDbContext;
        }

        public IEnumerable<TaskStatus> GetAll()
        {
            return taskManagerDbContext.TaskStatus.ToList();
        }
    }
}
