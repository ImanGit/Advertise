using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanySocialConfig : EntityTypeConfiguration<CompanySocial>
    {
        /// <summary>
        /// </summary>
        public CompanySocialConfig()
        {
            Property(companySocial => companySocial.YoutubeLink).IsOptional().HasMaxLength(100);
            Property(companySocial => companySocial.FacebookLink).IsOptional().HasMaxLength(100);
            Property(companySocial => companySocial.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(companySocial => companySocial.TwitterLink).IsOptional().HasMaxLength(100);
            Property(companySocial => companySocial.RowVersion).IsRowVersion();
        }
    }
}