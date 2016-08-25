using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    public class MessageConfig : EntityTypeConfiguration<Conversation>
    {
        public MessageConfig()
        {
            Property(message => message.Body).IsRequired().HasMaxLength(2000);
            Property(message => message.Title).IsOptional().HasMaxLength(200);
            Property(message => message.RowVersion).IsRowVersion();
        }
    }
}