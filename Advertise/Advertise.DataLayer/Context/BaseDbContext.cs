using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Advertise.Common.Utility;
using Advertise.DataLayer.Conventions;
using Advertise.DomainClasses.Configurations.Common;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.DomainClasses.Entities.Users;
using EFSecondLevelCache;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DataLayer.Context
{
    /// <summary>
    /// </summary>
    public class BaseDbContext : IdentityDbContext<User, Role, Guid, UserLogin, UserRole, UserClaim>
    {
        #region Constrans

        protected const string ConcurrencyMessage =
            "مقادیر در سمت بانک اطلاعاتی تغییر کرده‌اند. لطفا صفحه را ریفرش کنید.";

        #endregion

        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseDbContext(string connectionString) : base(connectionString)
        {
        }

        #endregion

        #region OnModelCreating

        /// <summary>
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

        #region RejectChanges

        /// <summary>
        /// </summary>
        public void RejectChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        #endregion

        #region UpdateAuditFields

        /// <summary>
        /// </summary>
        /// <param name="auditUserId"></param>
        private void UpdateAuditFields(Guid auditUserId)
        {
            var auditUserIp = HttpContext.Current.Request.GetIp();
            var auditUserAgent = HttpContext.Current.Request.GetBrowser();
            var auditDate = DateTime.Now;

            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                // Note: You must add a reference to assembly : System.Data.Entity
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Id = SequentialGuidGenerator.NewSequentialGuid();
                        entry.Entity.CreatedOn = auditDate;
                        entry.Entity.CreatedById = auditUserId;
                        entry.Entity.ModifiedOn = auditDate;
                        entry.Entity.Action = AuditLogType.Create;
                        entry.Entity.ModifiedById = auditUserId;
                        entry.Entity.CreatorIp = auditUserIp;
                        entry.Entity.ModifierIp = auditUserIp;
                        entry.Entity.CreatorAgent = auditUserAgent;
                        entry.Entity.ModifierAgent = auditUserAgent;
                        entry.Entity.Version = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedOn = auditDate;
                        entry.Entity.ModifiedById = auditUserId;
                        entry.Entity.ModifierIp = auditUserIp;
                        entry.Entity.ModifierAgent = auditUserAgent;
                        entry.Entity.Version = ++entry.Entity.Version;
                        entry.Entity.Action = entry.Entity.IsDeleted
                            ? AuditLogType.SoftDelete
                            : AuditLogType.Update;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            //فقط تعريف شده تا يك برك پوينت در اينجا قرار داده شود براي آزمايش فراخواني آن
            base.Dispose(disposing);
        }

        #endregion

        #region PrivateMethods

        /// <summary>
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

        private string[] GetChangedEntityNames()
        {
            return ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added ||
                            x.State == EntityState.Modified ||
                            x.State == EntityState.Deleted)
                .Select(x => ObjectContext.GetObjectType(x.Entity.GetType()).FullName)
                .Distinct()
                .ToArray();
        }

        #endregion

        #region SaveChanges

        public int SaveAllChanges(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            if (auditUserId.HasValue)
                UpdateAuditFields(auditUserId.Value);
            var result = SaveChanges();
            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }

        public Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            if (auditUserId.HasValue)
                UpdateAuditFields(auditUserId.Value);
            var result = SaveChangesAsync();
            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }

        #endregion

        #region Repository

        // public DbSet<Product> Products { get; set; }

        #endregion
    }
}