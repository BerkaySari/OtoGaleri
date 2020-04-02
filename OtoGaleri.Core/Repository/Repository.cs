using Microsoft.EntityFrameworkCore;
using OtoGaleri.Core.Entity;
using OtoGaleri.Core.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri.Core.Repository
{
    public class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : Entity<TPrimaryKey>
    {
        protected DbContext DbContext { get { return UnitOfWork.Current.DbContext; } }

        public void Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbContext.Set<TEntity>().AddRange(entities);
        }

        public void Delete(TPrimaryKey id)
        {
            TEntity item = DbContext.Set<TEntity>().Find(id);
            DbContext.Set<TEntity>().Remove(item);
        }

        public void Delete(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbContext.Set<TEntity>().Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            DbContext.Set<TEntity>().UpdateRange(entities);
        }

        public TEntity Get(TPrimaryKey id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }

        public TEntity Get(TEntity entity)
        {
            return DbContext.Set<TEntity>().Find(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>();
        }


        //Async methods
        public void AddAsync(TEntity entity)
        {
            DbContext.Set<TEntity>().AddAsync(entity);
        }

        public void AddRangeAsync(IEnumerable<TEntity> entities)
        {
            DbContext.Set<TEntity>().AddRangeAsync(entities);
        }

        public ValueTask<TEntity> GetAsync(TPrimaryKey id)
        {
            return DbContext.Set<TEntity>().FindAsync(id);
        }

        public ValueTask<TEntity> GetAsync(TEntity entity)
        {
            return DbContext.Set<TEntity>().FindAsync(entity);
        }
    }
}
