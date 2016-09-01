using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyQuestionReportConfig : EntityTypeConfiguration<CompanyQuestionReport>
    {
        /// <summary>
        /// </summary>
        public CompanyQuestionReportConfig()
        {
            Property(report => report.Reason).IsOptional().HasMaxLength(1000);
            Property(report => report.RowVersion).IsRowVersion();
        }
    }
}