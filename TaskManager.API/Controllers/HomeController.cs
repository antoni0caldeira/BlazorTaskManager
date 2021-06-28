using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.API.Data;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly TaskManagerDbContext _info;

        private HomeController(TaskManagerDbContext info)
        {
            _info = info ?? throw new ArgumentNullException(nameof(info));
        }
        [HttpGet]
        public IActionResult Home()
        {
            return Ok();
        }
    }
}
