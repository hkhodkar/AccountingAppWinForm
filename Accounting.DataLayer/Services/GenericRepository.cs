using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {

        private readonly Accounting_DBEntities _db;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> condition = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (condition != null)
            {
                query = query.Where(condition);
            }
            return query.ToList();
        }

        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }

    }
}
