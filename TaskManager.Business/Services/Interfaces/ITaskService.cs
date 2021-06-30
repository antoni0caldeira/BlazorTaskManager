using System.Collections.Generic;
using TaskManager.Business.Dtos;

namespace TaskManager.Business.Services.Interfaces
{
    public interface ITaskService
    {
        public IEnumerable<TaskDto> GetAll();
    }
}
