using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductSpecificationConfig : EntityTypeConfiguration<ProductSpecification>
    {
        /// <summary>
        /// </summary>
        public ProductSpecificationConfig()
        {
            Property(specification => specification.RowVersion).IsRowVersion();
        }
    }
}