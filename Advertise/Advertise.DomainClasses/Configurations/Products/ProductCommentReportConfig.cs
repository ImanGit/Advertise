using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductCommentReportConfig : EntityTypeConfiguration<ProductCommentReport>
    {
        /// <summary>
        /// </summary>
        public ProductCommentReportConfig()
        {
            Property(report => report.Reason).IsOptional().HasMaxLength(100);
            Property(report => report.RowVersion).IsRowVersion();
        }
    }
}