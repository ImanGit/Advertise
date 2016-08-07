using System.Data.Entity;
using Advertise.DataLayer.Context;

namespace Advertise.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class EfConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterEf()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DataLayer.Migrations.Configuration>());
        }
    }
}
