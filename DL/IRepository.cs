using System;
using System.Collections.Generic;
using System.Linq;

namespace DL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
