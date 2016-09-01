using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductVisitConfig : EntityTypeConfiguration<ProductVisit>
    {
        /// <summary>
        /// </summary>
        public ProductVisitConfig()
        {
            Property(productVisit => productVisit.RowVersion).IsRowVersion();
        }
    }
}