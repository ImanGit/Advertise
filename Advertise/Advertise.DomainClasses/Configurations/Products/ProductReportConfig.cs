using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductReportConfig : EntityTypeConfiguration<ProductReport>
    {
        /// <summary>
        /// </summary>
        public ProductReportConfig()
        {
            Property(report => report.Reason).IsOptional().HasMaxLength(100);
            Property(report => report.RowVersion).IsRowVersion();
        }
    }
}