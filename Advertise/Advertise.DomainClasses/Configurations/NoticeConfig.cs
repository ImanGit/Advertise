using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities;
namespace Advertise.DomainClasses.Configurations
{
    public  class NoticeConfig:EntityTypeConfiguration< Notice >
    {
        public NoticeConfig()
        {
            Property(notice => notice.Content ).IsRequired() .HasMaxLength(2000);
            Property(notice => notice.Title ).IsOptional().HasMaxLength(200);
            Property(notice => notice.RowVersion).IsRowVersion();
        }
    }
}
