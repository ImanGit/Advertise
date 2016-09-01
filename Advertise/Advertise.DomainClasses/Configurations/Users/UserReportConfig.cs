using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserReportConfig : EntityTypeConfiguration<UserReport>
    {
        /// <summary>
        /// </summary>
        public UserReportConfig()
        {
            Property(report => report.RowVersion).IsRowVersion();
        }
    }
}