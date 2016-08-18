using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    public class CompanyVisitConfig : EntityTypeConfiguration<CompanyVisit>
    {
        public CompanyVisitConfig()
        {
            Property(companyVisit => companyVisit.RowVersion).IsRowVersion();
        }
    }
}