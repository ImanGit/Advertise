using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Features;
using Advertise.DomainClasses.Entities.Paymenys;

namespace Advertise.DomainClasses.Configurations.Payments
{
    /// <summary>
    /// </summary>
    public class PaymentTransactionConfig : EntityTypeConfiguration<PaymentTransaction>
    {
        /// <summary>
        /// </summary>
        public PaymentTransactionConfig()
        {
            Property(transaction => transaction.RowVersion).IsRowVersion();
        }
    }
}