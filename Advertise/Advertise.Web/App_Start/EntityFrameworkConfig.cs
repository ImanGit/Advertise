using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.DomainClasses.Entities.Users;
using ElmahEFLogger.CustomElmahLogger;
using EntityFramework.Audit;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class EntityFrameworkConfig
    {
        /// <summary>
        /// </summary>
        public static void RegisterEntityFramework()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DataLayer.Migrations.Configuration>());
            //ApplicationObjectFactory.Container.GetInstance<IUnitOfWork>().ForceDatabaseInitialize();

            // config audit when your application is starting up...
            var auditConfiguration = AuditConfiguration.Default;
            auditConfiguration.IncludeRelationships = false;
            auditConfiguration.LoadRelationships = false;
            auditConfiguration.DefaultAuditable = false;
            AuditConfiguration.Default.IsAuditable<User>();
            AuditConfiguration.Default.IsAuditable<Company>();
            AuditConfiguration.Default.IsAuditable<Product>();

            //ad interception for logg EF errors
            DbInterception.Add(new ElmahEfInterceptor());
        }
    }
}