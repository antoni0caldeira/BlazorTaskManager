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

        public TaskStatus Create(TaskStatus entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TaskStatus> GetAll()
        {
            return taskManagerDbContext.TaskStatus.ToList();
        }

        public TaskStatus GetById(int entityId)
        {
            return taskManagerDbContext.TaskStatus.FirstOrDefault(x => x.Id == entityId);
        }

        public TaskStatus Update(TaskStatus entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
