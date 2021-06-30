using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerDAL.Data;
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
            return (IEnumerable<Task>)taskManagerDbContext.Tasks.ToList();
        }
    }
}
