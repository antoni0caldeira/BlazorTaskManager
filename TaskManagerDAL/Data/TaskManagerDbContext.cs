using Microsoft.EntityFrameworkCore;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Data
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskStatus> TaskStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasOne(b => b.Status)
                .WithMany();
        }
    }

}
