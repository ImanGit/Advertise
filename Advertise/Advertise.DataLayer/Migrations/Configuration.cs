using System.Data.Entity.Migrations;
using Advertise.DataLayer.Context;

namespace Advertise.DataLayer.Migrations
{
    /// <summary>
    /// </summary>
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        #region Ctor

        /// <summary>
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        #endregion Ctor

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ApplicationDbContext context)
        {
            //context.Users.Add(new User());
        }
    }
}