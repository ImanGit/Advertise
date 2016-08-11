using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;

namespace Advertise.DomainClasses.Configurations
{
    public class ActionConfig : EntityTypeConfiguration<Entities.Action>
    {
        public ActionConfig()
        {
            Property(action => action.ActionName).IsRequired().HasMaxLength(100);
            Property(action => action.ControllerName).IsRequired().HasMaxLength(100);
            Property(action => action.Title).IsRequired().HasMaxLength(100);
            Property(action => action.RowVersion).IsRowVersion();


        }
    }
}
