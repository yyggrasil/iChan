﻿using ichan.Domain.Base;
using ichan.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace ichan.Repository.Repository
{
    public class BaseRepository<TEntity>
        : IBaseRepository<TEntity> where TEntity
        : BaseEntity<int>
    {

        protected readonly MySqlContext _mySqlcontext;

        public BaseRepository(MySqlContext mySqlContext)
        {
            _mySqlcontext = mySqlContext;
        }

        public void AtachObjetct(object obj)
        {
            _mySqlcontext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlcontext.ChangeTracker.Clear();
        }

        public void Delete(object id)
        {
            _mySqlcontext.Set<TEntity>().Remove(Select(id));
            _mySqlcontext.SaveChanges();
        }

        public void Insert(TEntity entity)
        {
            _mySqlcontext.Set<TEntity>().Add(entity);
            _mySqlcontext.SaveChanges();
        }

        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsNoTracking().AsQueryable();
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlcontext.Set<TEntity>().AsNoTracking().AsQueryable();
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }

        public void Update(TEntity entity)
        {
            _mySqlcontext.Entry(entity).State = EntityState.Modified;
            _mySqlcontext.SaveChanges();
        }
    }
}
