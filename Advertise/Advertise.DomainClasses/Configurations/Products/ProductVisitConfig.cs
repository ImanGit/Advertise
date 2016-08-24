using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    public class ProductVisitConfig : EntityTypeConfiguration<ProductVisit>
    {
        public ProductVisitConfig()
        {
            Property(productVisit => productVisit.RowVersion).IsRowVersion();
        }
    }
}