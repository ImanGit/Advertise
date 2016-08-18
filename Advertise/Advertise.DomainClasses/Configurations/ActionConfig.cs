using System.Data.Entity.ModelConfiguration;

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