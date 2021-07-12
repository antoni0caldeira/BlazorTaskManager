using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManager.Business.Dtos;
using TaskManager.Business.Services.Interfaces;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskStatusController : ControllerBase
    {
        private ITaskStatusService taskStatusService;

        public TaskStatusController(ITaskStatusService taskStatusService)
        {
            this.taskStatusService = taskStatusService;
        }

        [HttpGet]
        public IEnumerable<TaskStatusDto> GetAll()
        {
            return taskStatusService.GetAll();
        }

        [HttpGet("{id}")]
        public TaskStatusDto GetById(int id)
        {
            var taskStatusDto = taskStatusService.GetById(id);
            return taskStatusDto;
        }
    }
}
