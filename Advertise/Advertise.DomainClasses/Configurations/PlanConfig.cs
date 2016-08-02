using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class PlanConfig : EntityTypeConfiguration<Plan>
    {
        /// <summary>
        /// 
        /// </summary>
        public PlanConfig()
        {
            ToTable("AD_Plan");

            Property(plan => plan.Code).IsRequired().HasMaxLength(50);
            Property(plan => plan.CostValue).IsRequired();
            Property(plan => plan.Description).IsOptional().HasMaxLength(250);
            Property(plan => plan.DurationDay).IsRequired();
            Property(plan => plan.FromDate).IsRequired();
            Property(plan => plan.IsEnabled).IsRequired();
            Property(plan => plan.Title).IsRequired().HasMaxLength(100);
            Property(plan => plan.ToDate).IsRequired();
            Property(plan => plan.RowVersion).IsRowVersion();
        }
    }
}
