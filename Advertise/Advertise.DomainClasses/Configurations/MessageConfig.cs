using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;

namespace Advertise.DomainClasses.Configurations
{
    public  class MessageConfig:EntityTypeConfiguration< Conversation >
    {
        public MessageConfig()
        {
            Property(message => message.Content ).IsRequired() .HasMaxLength(2000);
            Property(message => message.Title ).IsOptional().HasMaxLength(200);
            Property(message => message.RowVersion).IsRowVersion();
        }
    }
}
