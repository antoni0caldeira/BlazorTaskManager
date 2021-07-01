using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Services.Interfaces
{
    public interface ITaskService
    {
        public IEnumerable<TaskDto> GetAll();
        Task GetById(int taskId);
        void Delete(int taskId);
    }
}
