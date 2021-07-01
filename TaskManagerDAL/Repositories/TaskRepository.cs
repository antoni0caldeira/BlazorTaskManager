using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public Task Create(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Task> GetAll()
        {
            var result = taskManagerDbContext.Tasks.Include(x => x.Status).ToList();
            return result;
        }

        public Task GetById(int entityId)
        {
            return taskManagerDbContext.Tasks.FirstOrDefault(c => c.Id == entityId);
        }

        public Task Update(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Task> GetByFilters(int status, DateTimeOffset starDate, DateTimeOffset endDate)
        {
            throw new NotImplementedException();
        }
    }
}
