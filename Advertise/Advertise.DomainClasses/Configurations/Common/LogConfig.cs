using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Configurations
{
    public class LogConfig : EntityTypeConfiguration<Log>
    {
        public LogConfig()
        {
            Property(log => log.Action).IsOptional().HasMaxLength(11);
            Property(log => log.RowVersion).IsRowVersion();
        }
    }
}