using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;
namespace Advertise.DomainClasses.Configurations
{
    public  class FollowConfig:EntityTypeConfiguration< Follow >
    {
        public FollowConfig()
        {
            Property(follow => follow.RowVersion );
        }
    }
}
