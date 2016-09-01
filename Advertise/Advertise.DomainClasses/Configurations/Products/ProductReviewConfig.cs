using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductReviewConfig : EntityTypeConfiguration<ProductReview>
    {
        /// <summary>
        /// </summary>
        public ProductReviewConfig()
        {
            Property(review => review.Body).IsRequired().HasMaxLength(1000);
            Property(review => review.RowVersion).IsRowVersion();
        }
    }
}