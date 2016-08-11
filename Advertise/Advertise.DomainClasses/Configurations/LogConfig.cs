using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;
namespace Advertise.DomainClasses.Configurations
{
    public  class LogConfig:EntityTypeConfiguration< Log >
    {
        public LogConfig()
        {
            Property(log => log.Action ).IsOptional().HasMaxLength(11);
            Property(log => log.RowVersion).IsRowVersion();
        }
    }
}
