using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class CompanySocialConfig : EntityTypeConfiguration<CompanySocial>
    {
        /// <summary>
        /// </summary>
        public CompanySocialConfig()
        {
            //ToTable("AD_Social");

            Property(companysocial => companysocial.AparatLink).IsOptional().HasMaxLength(100);
            Property(companysocial => companysocial.FacebookLink).IsOptional().HasMaxLength(100);
            Property(companysocial => companysocial.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(companysocial => companysocial.TwitterLink).IsOptional().HasMaxLength(100);
            Property(companysocial => companysocial.RowVersion).IsRowVersion();
        }
    }
}