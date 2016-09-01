using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyReportConfig : EntityTypeConfiguration<CompanyReport>
    {
        /// <summary>
        /// </summary>
        public CompanyReportConfig()
        {
            Property(report => report.RowVersion).IsRowVersion();
        }
    }
}