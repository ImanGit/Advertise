using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        /// <summary>
        /// </summary>
        public AddressConfig()
        {
            Property(address => address.RowVersion).IsRowVersion();
        }
    }
}