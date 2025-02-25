﻿namespace ichan.Domain.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : IBaseEntity
    {
        void ClearChangeTracker();
        void AtachObjetct(object obj);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        IList<TEntity> Select(bool tracking = true, IList<string>? includes = null);
        TEntity Select(object id, bool tracking = true, IList<string>? includes = null);
    }
}
