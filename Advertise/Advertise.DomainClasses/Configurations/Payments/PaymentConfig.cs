using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Paymenys;

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

        }
    }
}