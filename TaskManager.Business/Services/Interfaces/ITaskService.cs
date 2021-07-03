using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Services.Interfaces
{
    public interface ITaskService
    {
        public IEnumerable<TaskDto> GetAll();
        TaskDto GetById(int taskId);
        void Delete(int taskId);
        TaskDto Create(TaskDto task);
    }
}
