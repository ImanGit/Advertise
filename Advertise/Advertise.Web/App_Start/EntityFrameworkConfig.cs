using System.Data.Entity;
using Advertise.DataLayer.Context;

namespace Advertise.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class EntityFrameworkConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterEntityFramework()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DataLayer.Migrations.Configuration>());
        }
    }
}
