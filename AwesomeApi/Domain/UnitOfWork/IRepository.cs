using System.Collections.Generic;

namespace Domain.UnitOfWork
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();

        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}