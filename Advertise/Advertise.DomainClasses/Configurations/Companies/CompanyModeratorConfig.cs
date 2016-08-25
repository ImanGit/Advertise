using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyModeratorConfig : EntityTypeConfiguration<CompanyModerator>
    {
        /// <summary>
        /// </summary>
        public CompanyModeratorConfig()
        {
            Property(moderator => moderator.RowVersion).IsRowVersion();
        }
    }
}