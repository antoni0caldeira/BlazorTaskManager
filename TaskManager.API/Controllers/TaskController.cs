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
        public TaskDto GetById(int id)
        {
            var taskDto =  taskService.GetById(id);
            //if (taskDto != null) return taskDto;
            //return null;
            return taskDto;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            //taskService.GetById(id);
            taskService.Delete(id);

            return NoContent();
        }
        [HttpPost]
        public IActionResult Create(TaskDto taskDto)
        {
            taskService.Create(taskDto);
            return Ok();
        }
    }
}
