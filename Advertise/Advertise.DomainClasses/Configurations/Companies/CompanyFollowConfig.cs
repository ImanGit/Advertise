using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    public class CompanyFollowConfig : EntityTypeConfiguration<CompanyFollow>
    {
        public CompanyFollowConfig()
        {
            Property(follow => follow.RowVersion);
        }
    }
}