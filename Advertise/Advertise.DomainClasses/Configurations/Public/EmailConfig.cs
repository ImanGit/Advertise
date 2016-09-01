using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class EmailConfig : EntityTypeConfiguration<Email>
    {
        /// <summary>
        /// </summary>
        public EmailConfig()
        {
            Property(email => email.Subject).IsRequired().HasMaxLength(100);
            Property(email => email.Body).IsRequired().HasMaxLength(1000);
            Property(email => email.RowVersion).IsRowVersion();
        }
    }
}