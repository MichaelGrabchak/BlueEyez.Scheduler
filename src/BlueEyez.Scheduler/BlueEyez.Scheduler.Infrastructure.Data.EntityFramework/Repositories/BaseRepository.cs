﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;
using BlueEyez.Scheduler.Domain.Data.Repositories;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories
{
    public abstract class BaseRepository<TEntity, TIdentity> : IRepository<TEntity, TIdentity>
        where TEntity : class
    {
        protected readonly DbContext DbContext;
        protected readonly IApplicationContext SchedulerContext;
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository(IDbContextProvider dbContextProvider, IApplicationContext schedulerContext)
        {
            DbContext = dbContextProvider?.DbContext ?? throw new ArgumentNullException(nameof(dbContextProvider));
            SchedulerContext = schedulerContext;
            DbSet = DbContext.Set<TEntity>();
        }

        #region Create

        public void Add(TEntity entity)
        {
            AddEntity(entity);
            SaveChanges();
        }

        #endregion

        #region Read

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(TIdentity id)
        {
            return DbSet.Find(id);
        }

        #endregion

        #region Update

        public void Update(TEntity entity)
        {
            UpdateEntity(entity);
            SaveChanges();
        }

        #endregion

        #region Delete

        public void Delete(TEntity entity)
        {
            DeleteEntity(entity);
            SaveChanges();
        }

        #endregion

        #region Create/Update

        public void AddOrUpdate(TEntity entity)
        {
            if (!UpdateEntity(entity))
            {
                AddEntity(entity);
            }
            SaveChanges();
        }

        #endregion

        #region Protected virtual methods

        protected virtual void AddEntity(TEntity entity)
        {
            DbSet.Add(entity);
        }

        protected virtual bool UpdateEntity(dynamic entity)
        {
            var original = GetById(entity.Id);
            if (original == null)
            {
                return false;
            }

            DbContext.Entry(original).CurrentValues.SetValues(entity);
            return true;
        }

        protected virtual void DeleteEntity(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        #endregion

        #region Helpers

        protected void SaveChanges()
        {
            DbContext.SaveChanges();
        }

        #endregion
    }
}
