using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    internal class NotificationConfig : EntityTypeConfiguration<Notification>
    {
        public NotificationConfig()
        {
            Property(notification => notification.RowVersion).IsRowVersion();
        }
    }
}