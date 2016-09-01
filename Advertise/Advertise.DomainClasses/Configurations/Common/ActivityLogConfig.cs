using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Configurations.Common
{
    /// <summary>
    /// </summary>
    public class ActivityLogConfig : EntityTypeConfiguration<ActivityLog>
    {
        /// <summary>
        /// </summary>
        public ActivityLogConfig()
        {
            Property(log => log.RowVersion).IsRowVersion();
        }
    }
}