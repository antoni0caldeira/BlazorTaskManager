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
                TaskStatus = x.TaskStatus,
                UserId = x.UserId

            });

            return result;
        }

        public Task GetTaskById(int taskId)
        {
            return taskRepository.GetTaskById(taskId);
        }

        public void DeleteTask(int taskId)
        {
            taskRepository.DeleteTask(taskId);
            return;
        }
    }
}
