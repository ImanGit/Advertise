using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Roles;

namespace Advertise.DomainClasses.Configurations
{
    public class ActionConfig : EntityTypeConfiguration<RoleAction>
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