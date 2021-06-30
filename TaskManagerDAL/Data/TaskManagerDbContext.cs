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
                .HasOne(p => p.TaskStatus)//uma task tem um taskstatus
                .WithMany(t => t.Tasks)// um taskstatus tem várias task
                .HasForeignKey(p => p.TaskStatusId); // chave estrangeira
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskStatus> TaskStatus { get; set; }


    }

}
