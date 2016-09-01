using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductShareConfig : EntityTypeConfiguration<ProductShare>
    {
        /// <summary>
        /// </summary>
        public ProductShareConfig()
        {
            Property(share => share.RowVersion).IsRowVersion();
        }
    }
}