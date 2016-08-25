using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations
{
    public class BudgetConfig : EntityTypeConfiguration<UserBudget>
    {
        public BudgetConfig()
        {
            //ToTable("AD_Budgets");
        }
    }
}