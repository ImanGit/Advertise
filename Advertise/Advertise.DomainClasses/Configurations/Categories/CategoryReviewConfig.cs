using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Categories;

namespace Advertise.DomainClasses.Configurations.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryReviewConfig : EntityTypeConfiguration<CategoryReview>
    {
        /// <summary>
        /// </summary>
        public CategoryReviewConfig()
        {
            Property(review => review.Body).HasMaxLength(1000).IsRequired();
            Property(review => review.RowVersion).IsRowVersion();
        }
    }
}