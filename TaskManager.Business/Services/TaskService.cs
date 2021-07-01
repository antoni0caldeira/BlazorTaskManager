using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManager.Business.Services.Interfaces;
using TaskManagerDAL.Repositories.Interfaces;
using System.Linq;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<TaskDto> GetAll()
        {
            var result = taskRepository.GetAll().Select(x => new TaskDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = new TaskStatusDto { Id = x.Status.Id, Name = x.Status.Name},
                UserId = x.UserId

            });

            return result;
        }

        public Task GetById(int taskId)
        {
            return taskRepository.GetById(taskId);
        }

        public void Delete(int taskId)
        {
            taskRepository.Delete(taskId);
            return;
        }
    }
}
