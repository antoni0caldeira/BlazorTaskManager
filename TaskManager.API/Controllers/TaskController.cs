using Microsoft.AspNetCore.Mvc;
using System;
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
            return taskDto;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            taskService.Delete(id);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(TaskDto taskDto)
        {
            var result = taskService.Create(taskDto);

            if(result == null)
            {
                return new BadRequestResult();
            }
            return Ok(taskDto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskDto taskDto)
        {
            taskService.Update(id, taskDto);
            return Ok(taskDto);
        }

    //    [HttpGet("{status}")]
    //    public IEnumerable<TaskDto> getGetByFilters(int status, DateTimeOffset starDate, DateTimeOffset endDate)
    //    {
    //        return taskService.GetByFilters(status, starDate, endDate);
    //    }
    }
}
