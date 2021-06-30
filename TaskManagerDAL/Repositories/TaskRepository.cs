using System.Collections.Generic;
using System.Linq;
using TaskManagerDAL.Data;
using TaskManagerDAL.Models;
using TaskManagerDAL.Repositories.Interfaces;

namespace TaskManagerDAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private TaskManagerDbContext taskManagerDbContext;

        public TaskRepository(TaskManagerDbContext taskManagerDbContext)
        {
            this.taskManagerDbContext = taskManagerDbContext;
        }

        IEnumerable<Task> ITaskRepository.GetAll()
        {
            return taskManagerDbContext.Tasks.ToList();
        }
    }
}
