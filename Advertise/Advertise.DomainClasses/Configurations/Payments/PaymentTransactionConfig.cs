using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Features;

namespace Advertise.DomainClasses.Configurations.Payments
{
    /// <summary>
    /// </summary>
    public class PaymentTransactionConfig : EntityTypeConfiguration<Feature>
    {
        /// <summary>
        /// </summary>
        public PaymentTransactionConfig()
        {
            //ToTable("AD_Plan");

            Property(plan => plan.Code).IsRequired().HasMaxLength(50);

            Property(plan => plan.Description).IsOptional().HasMaxLength(250);
            Property(plan => plan.DurationDay).IsRequired();

            Property(plan => plan.Title).IsRequired().HasMaxLength(100);

            Property(plan => plan.RowVersion).IsRowVersion();
        }
    }
}