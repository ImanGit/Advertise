using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserBudgetConfig : EntityTypeConfiguration<UserBudget>
    {
        /// <summary>
        /// </summary>
        public UserBudgetConfig()
        {
            Property(budget => budget.RowVersion).IsRowVersion();
        }
    }
}