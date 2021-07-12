using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManager.Business.Services.Interfaces;
using TaskManagerDAL.Repositories.Interfaces;
using System.Linq;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Services
{
    public class TaskStatusService : ITaskStatusService
    {
        private ITaskStatusRepository taskStatusRepository;

        public TaskStatusService(ITaskStatusRepository taskStatusRepository)
        {
            this.taskStatusRepository = taskStatusRepository;
        }

        public IEnumerable<TaskStatusDto> GetAll()
        {
            return taskStatusRepository.GetAll().Select(x => new TaskStatusDto
            {
                Id = x.Id,
                Name = x.Name
            });
        }

        public TaskStatusDto GetById(int taskId)
        {
            TaskStatusDto result = null;
            TaskStatus taskStatus = taskStatusRepository.GetById(taskId);
            if (taskStatus != null)
            {
                result = new TaskStatusDto
                {
                    Id = taskStatus.Id,
                    Name = taskStatus.Name,
                };
            }
            return result;
        }

    }
}
