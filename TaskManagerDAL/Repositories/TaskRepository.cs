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
            var addedEntity = taskManagerDbContext.Tasks.Add(entity);
            taskManagerDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public void Delete(int entityId)
        {
            var task = taskManagerDbContext.Tasks.FirstOrDefault(c => c.Id == entityId);
            if (task == null) return;

            taskManagerDbContext.Tasks.Remove(task);
            taskManagerDbContext.SaveChanges();
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
            var task = taskManagerDbContext.Tasks.FirstOrDefault(e => e.Id == entity.Id);

            if (task != null)
            {
                task.Id = entity.Id;
                task.Title = entity.Title;
                task.Description = entity.Description;
                task.StartDate = entity.StartDate;
                task.EndDate = entity.EndDate;
                task.Status = entity.Status;
                task.UserId = entity.UserId;

                taskManagerDbContext.SaveChanges();

                return task;
            }

            return null;
        }

        public IEnumerable<Task> GetByFilters(int status, DateTimeOffset starDate, DateTimeOffset endDate)
        {
            throw new NotImplementedException();
        }
    }
}
