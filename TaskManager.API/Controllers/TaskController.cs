using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManager.Business.Services.Interfaces;
using TaskManagerDAL.Models;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public IEnumerable<TaskDto> GetAll()
        {
            return taskService.GetAll();
        }

        [HttpGet("{id}")]
        public  Task GetTaskById(int id)
        {
            return taskService.GetTaskById(id);
        }

        [HttpDelete("{id}")]
        public void DeleteTask(int id)
        {
            
            var taskToDelete = taskService.GetTaskById(id);

            taskService.DeleteTask(id);

            return;
        }
    }
}
