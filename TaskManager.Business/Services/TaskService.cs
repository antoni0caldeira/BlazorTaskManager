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

        public TaskDto GetById(int taskId)
        {
            TaskDto result = null;
            Task task = taskRepository.GetById(taskId);
            if (task != null)
            {
                result = new TaskDto
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    StartDate = task.StartDate,
                    EndDate = task.EndDate,
                    Status = new TaskStatusDto { Id = task.Status.Id, Name = task.Status.Name },
                    UserId = task.UserId
                };

            }
            return result;
        }

        public void Delete(int taskId)
        {
            taskRepository.Delete(taskId);
            return;
        }

        public TaskDto Create(TaskDto taskDto)
        {
            TaskDto result = null;
            if(taskDto != null)
            {
                Task taskToCreate = new Task
                {
                    Id = taskDto.Id,
                    Title = taskDto.Title,
                    Description = taskDto.Description,
                    StartDate = taskDto.StartDate,
                    EndDate = taskDto.EndDate,
                    Status = { Id = taskDto.Status.Id, Name = taskDto.Status.Name },
                    UserId = taskDto.UserId,
                };

                taskToCreate = taskRepository.Create(taskToCreate);

                result = new TaskDto
                {
                    Id = taskToCreate.Id,
                    Title = taskToCreate.Title,
                    Description = taskToCreate.Description,
                    StartDate = taskToCreate.StartDate,
                    EndDate = taskToCreate.EndDate,
                    Status = { Id = taskToCreate.Status.Id, Name = taskToCreate.Status.Name },
                    UserId = taskToCreate.UserId
                };
            }
                        
            return result;
        }
    }
}
