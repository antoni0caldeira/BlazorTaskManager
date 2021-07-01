using System.Collections.Generic;

namespace TaskManagerDAL.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int entityId);
        void Delete(int entityId);
        T Create(T entity);
        T Update(T entity);
    }
}
