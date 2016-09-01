using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class SmsConfig : EntityTypeConfiguration<Sms>
    {
        /// <summary>
        /// </summary>
        public SmsConfig()
        {
            Property(sms => sms.Body).IsRequired().HasMaxLength(1000);
            Property(sms => sms.RowVersion).IsRowVersion();
        }
    }
}