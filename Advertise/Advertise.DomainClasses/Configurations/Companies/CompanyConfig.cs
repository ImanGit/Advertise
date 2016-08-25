using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyConfig : EntityTypeConfiguration<Company>
    {
        /// <summary>
        /// </summary>
        public CompanyConfig()
        {
            Property(company => company.Email).IsOptional().HasMaxLength(100);
            Property(company => company.BackgroundFileName).IsOptional().HasMaxLength(100);
            Property(company => company.LogoFileName).IsOptional().HasMaxLength(100);
            Property(company => company.Description).IsRequired().HasMaxLength(1000);
            Property(company => company.MobileNumber).IsRequired().HasMaxLength(10);
            Property(company => company.PhoneNumber).IsRequired().HasMaxLength(10);
            Property(company => company.Code).IsRequired().HasMaxLength(100);
            Property(company => company.BrandName).IsRequired().HasMaxLength(100);
            Property(company => company.WebSite).IsOptional().HasMaxLength(100);
            Property(company => company.RowVersion).IsRowVersion();
        }
    }
}