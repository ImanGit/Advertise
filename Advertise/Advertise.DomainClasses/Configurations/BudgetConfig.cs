using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses .Entities ;
using Advertise.DomainClasses.Entities.Plans;

namespace Advertise.DomainClasses.Configurations
{
    public  class BudgetConfig:EntityTypeConfiguration<Budget>
    {
        public BudgetConfig()
        {
            ToTable("AD_Budgets");
        }
    }
}
