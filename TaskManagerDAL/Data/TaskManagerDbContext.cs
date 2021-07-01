using Microsoft.EntityFrameworkCore;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Data
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasOne(p => p.Status);
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskStatus> TaskStatus { get; set; }


    }

}
