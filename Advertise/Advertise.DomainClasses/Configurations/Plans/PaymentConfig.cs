using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Plans;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class PaymentConfig : EntityTypeConfiguration<Payment>
    {
        /// <summary>
        /// </summary>
        public PaymentConfig()
        {
            //ToTable("AD_Payment");

            Property(payment => payment.CreateDate).IsRequired();
            Property(payment => payment.FromDate).IsRequired();
            Property(payment => payment.ToDate).IsRequired();
            Property(payment => payment.RowVersion).IsRowVersion();
        }
    }
}