using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// 
    /// </summary>
    public class CompanyVisitConfig : EntityTypeConfiguration<CompanyVisit>
    {
        /// <summary>
        /// 
        /// </summary>
        public CompanyVisitConfig()
        {
            Property(companyVisit => companyVisit.RowVersion).IsRowVersion();
        }
    }
}