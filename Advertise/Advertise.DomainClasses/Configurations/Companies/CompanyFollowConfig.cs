using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyFollowConfig : EntityTypeConfiguration<CompanyFollow>
    {
        /// <summary>
        /// </summary>
        public CompanyFollowConfig()
        {
            Property(follow => follow.RowVersion).IsRowVersion();
        }
    }
}