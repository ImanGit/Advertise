using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Plans;

namespace Advertise.DomainClasses.Configurations
{
    public class BudgetConfig : EntityTypeConfiguration<Budget>
    {
        public BudgetConfig()
        {
            ToTable("AD_Budgets");
        }
    }
}