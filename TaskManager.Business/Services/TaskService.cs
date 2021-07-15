using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManager.Business.Services.Interfaces;
using TaskManagerDAL.Repositories.Interfaces;
using System.Linq;
using TaskManagerDAL.Models;
using System;

namespace TaskManager.Business.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository;
        private ITaskStatusRepository taskStatusRepository;

        public TaskService(ITaskRepository taskRepository, ITaskStatusRepository taskStatusRepository)
        {
            this.taskRepository = taskRepository;
            this.taskStatusRepository = taskStatusRepository;
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
                TaskStatus status = taskStatusRepository.GetById(taskDto.Status.Id);
                if (status == null)
                {
                    return null;
                }

                Task taskToCreate = new Task
                {
                    //Id = taskDto.Id,
                    Title = taskDto.Title,
                    Description = taskDto.Description,
                    StartDate = taskDto.StartDate,
                    EndDate = taskDto.EndDate,
                    Status = status,
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
                    Status = new TaskStatusDto { Id = taskToCreate.Status.Id, Name = taskToCreate.Status.Name },
                    UserId = taskToCreate.UserId
                };
            }
                        
            return result;
        }

        public TaskDto Update(int taskId, TaskDto taskDto)
        {
            TaskDto result = null;
            if (taskDto != null)
            {
                TaskStatus status = taskStatusRepository.GetById(taskDto.Status.Id);
                Task taskToUpdate = new Task
                {
                    Id = taskId,
                    Title = taskDto.Title,
                    Description = taskDto.Description,
                    StartDate = taskDto.StartDate,
                    EndDate = taskDto.EndDate,
                    Status = status,
                    UserId = taskDto.UserId,
                };

                taskToUpdate = taskRepository.Update(taskToUpdate);

                result = new TaskDto
                {
                    Id = taskToUpdate.Id,
                    Title = taskToUpdate.Title,
                    Description = taskToUpdate.Description,
                    StartDate = taskToUpdate.StartDate,
                    EndDate = taskToUpdate.EndDate,
                    Status = new TaskStatusDto{ Id = taskToUpdate.Status.Id, Name = taskToUpdate.Status.Name },
                    UserId = taskToUpdate.UserId
                };
            }
            return result;
        }

        public IEnumerable<TaskDto>GetByFilters(int status, DateTimeOffset starDate, DateTimeOffset endDate)
        {
            var result = taskRepository.GetByFilters(status, starDate, endDate).Select(x => new TaskDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = new TaskStatusDto { Id = x.Status.Id, Name = x.Status.Name },
                UserId = x.UserId

            });

            return result;
        }
    }
    
}
