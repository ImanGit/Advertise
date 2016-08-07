using System;
using System.Linq;
using System.Data.Entity;
using System.Reflection;
using Advertise.DataLayer.Conventions;
using Advertise.DomainClasses.Configurations;
using Advertise.DomainClasses.Configurations.Common;
using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DataLayer.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDbContext : DbContext
    {
        #region Repository

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; } 

        #endregion

        #region Ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseDbContext(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region Override OnModelCreating

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Conventions.Add(new CustomeConvention());

            modelBuilder.Configurations.AddFromAssembly(typeof (BaseConfig).Assembly);
            LoadEntities(typeof (BaseEntity).Assembly, modelBuilder, "Advertise.DomainClasses.Entities");
        }

        #endregion

        #region PrivateMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="modelBuilder"></param>
        /// <param name="nameSpace"></param>
        private static void LoadEntities(Assembly asm, DbModelBuilder modelBuilder, string nameSpace)
        {
            var entityTypes = asm.GetTypes()
                .Where(type => type.BaseType != null &&
                               type.Namespace == nameSpace &&
                               type.BaseType == null)
                .ToList();

            entityTypes.ForEach(modelBuilder.RegisterEntityType);
        }

        #endregion
    }
}
