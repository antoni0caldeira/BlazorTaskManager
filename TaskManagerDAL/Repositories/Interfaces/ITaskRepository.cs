using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetAll();
    }
}
