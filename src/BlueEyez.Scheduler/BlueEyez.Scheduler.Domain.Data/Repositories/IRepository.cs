﻿using System.Collections.Generic;

namespace BlueEyez.Scheduler.Domain.Data.Repositories
{
    public interface IRepository<TEntity, in TIdentity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TIdentity id);
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void AddOrUpdate(TEntity entity);
    }
}
