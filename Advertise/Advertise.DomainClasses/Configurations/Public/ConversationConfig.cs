using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class ConversationConfig : EntityTypeConfiguration<Conversation>
    {
        /// <summary>
        /// </summary>
        public ConversationConfig()
        {
            Property(message => message.Body).IsRequired().HasMaxLength(1000);
            Property(message => message.Title).IsOptional().HasMaxLength(100);
            Property(message => message.RowVersion).IsRowVersion();
        }
    }
}