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
            Property(review => review.Body).IsRequired().HasMaxLength(1000);
            Property(review => review.RowVersion).IsRowVersion();
        }
    }
}