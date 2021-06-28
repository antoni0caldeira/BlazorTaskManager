using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.API.Models;

namespace TaskManager.API.Data
{
    class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Status> Status { get; set; }
    

    }

}
