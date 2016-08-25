using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyQuestionLikeConfig : EntityTypeConfiguration<CompanyQuestionLike>
    {
        /// <summary>
        /// </summary>
        public CompanyQuestionLikeConfig()
        {
            Property(like => like.RowVersion).IsRowVersion();
        }
    }
}