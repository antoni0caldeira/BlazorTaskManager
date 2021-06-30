using System.Linq;
using TaskManagerDAL.Models;

namespace TaskManagerDAL.Data
{
    public class SeedData
    {
        internal void InsertAll(TaskManagerDbContext DbContext) {
            InsertStatusData(DbContext);
            InsertTasksData(DbContext);
        }


        private void InsertStatusData(TaskManagerDbContext DbContext)
        {
            if (DbContext.TaskStatus.Any()) return;
            DbContext.TaskStatus.AddRange(new TaskStatus[]
            {
                new TaskStatus
            {
                Name = "Pending",
            },
            new TaskStatus
            {
                Name = "In Progress",
            },
            new TaskStatus
            {
                Name = "Done",
            },
            new TaskStatus
            {
                Name = "Late",
            },


            });
            DbContext.SaveChanges();
        }
        private void InsertTasksData(TaskManagerDbContext DbContext)
        {
        }
    }

    
}
