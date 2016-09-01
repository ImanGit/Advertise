using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyReviewConfig : EntityTypeConfiguration<CompanyReview>
    {
        /// <summary>
        /// </summary>
        public CompanyReviewConfig()
        {
            Property(review => review.Body).IsRequired().HasMaxLength(1000);
            Property(review => review.RowVersion).IsRowVersion();
        }
    }
}