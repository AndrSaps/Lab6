using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DL
{
    public class Repository<TEntity> :DataSupertype ,IRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll()
        {
            return this.Context.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return this.Context.Set<TEntity>().Find(id);
        }

        public void Create(TEntity item)
        {
            this.Context.Set<TEntity>().Add(item);
            this.Context.SaveChanges();
        }
        public void Update(TEntity item)
        {
            this.Context.Entry(item).State = EntityState.Modified;
            this.Context.SaveChanges();
        }
        public void Remove(TEntity item)
        {
            this.Context.Set<TEntity>().Remove(item);
            this.Context.SaveChanges();
        }
    }
}
