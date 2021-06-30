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
            var result = taskManagerDbContext.Tasks.ToList();
            return result;
        }
        public Task GetTaskById(int taskId)
        {
            return taskManagerDbContext.Tasks.FirstOrDefault(c => c.Id == taskId);
        }
    }
}
