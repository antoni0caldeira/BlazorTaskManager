using System.Collections.Generic;
using TaskManager.Business.Dtos;

namespace TaskManager.Business.Services.Interfaces
{
    public interface ITaskStatusService
    {
        public IEnumerable<TaskStatusDto> GetAll();
        TaskStatusDto GetById(int taskId);
    }
}
