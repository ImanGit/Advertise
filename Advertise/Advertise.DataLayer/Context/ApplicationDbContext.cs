using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Advertise.DataLayer.Context
{
    /// <summary>
    /// </summary>
    public class ApplicationDbContext : BaseDbContext, IUnitOfWork
    {
        #region Ctor

        /// <summary>
        /// </summary>
        public ApplicationDbContext() : base("ApplicationConnection")
        {
        }

        #endregion

        #region IUnitOfWork

        public T Update<T>(T entity, Expression<Func<IUpdateConfiguration<T>, object>> mapping) where T : class, new()
        {
            return this.UpdateGraph(entity, mapping);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Detached;
        }

        public void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Added;
        }

        public void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Deleted;
        }

        public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
        {
            return Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public void AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            ((DbSet<TEntity>) Set<TEntity>()).AddRange(entities);
        }

        public void ForceDatabaseInitialize()
        {
            Database.Initialize(true);
        }

        public void EnableFiltering(string name)
        {
            this.EnableFilter(name);
        }

        public void EnableFiltering(string name, string parameter, object value)
        {
            this.EnableFilter(name).SetParameter(parameter, value);
        }

        public void DisableFiltering(string name)
        {
            this.DisableFilter(name);
        }

        public void BulkInsertData<T>(IEnumerable<T> data)
        {
            this.BulkInsert(data);
        }

        public bool ValidateOnSaveEnabled
        {
            get { return Configuration.ValidateOnSaveEnabled; }
            set { Configuration.ValidateOnSaveEnabled = value; }
        }

        public bool ProxyCreationEnabled
        {
            get { return Configuration.ProxyCreationEnabled; }
            set { Configuration.ProxyCreationEnabled = value; }
        }

        bool IUnitOfWork.AutoDetectChangesEnabled
        {
            get { return Configuration.AutoDetectChangesEnabled; }
            set { Configuration.AutoDetectChangesEnabled = value; }
        }

        public bool ForceNoTracking { get; set; }

        #endregion
    }
}