using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Notifications;

namespace Advertise.DomainClasses.Configurations.Notifications
{
    /// <summary>
    /// </summary>
    public class NotificationConfig : EntityTypeConfiguration<Notification>
    {
        /// <summary>
        /// </summary>
        public NotificationConfig()
        {
            Property(notification => notification.Message).IsRequired().HasMaxLength(100);
            Property(notification => notification.RowVersion).IsRowVersion();
        }
    }
}