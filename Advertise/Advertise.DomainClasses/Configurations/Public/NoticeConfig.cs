using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    public class NoticeConfig : EntityTypeConfiguration<News>
    {
        public NoticeConfig()
        {
            Property(notice => notice.Content).IsRequired().HasMaxLength(2000);
            Property(notice => notice.Title).IsOptional().HasMaxLength(200);
            Property(notice => notice.RowVersion).IsRowVersion();
        }
    }
}