using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Roles;

namespace Advertise.DomainClasses.Configurations.Roles
{
    /// <summary>
    /// </summary>
    public class RoleActionConfig : EntityTypeConfiguration<RoleAction>
    {
        /// <summary>
        /// </summary>
        public RoleActionConfig()
        {
            Property(action => action.ActionName).IsRequired().HasMaxLength(100);
            Property(action => action.ControllerName).IsRequired().HasMaxLength(100);
            Property(action => action.Title).IsRequired().HasMaxLength(100);
            Property(action => action.RowVersion).IsRowVersion();
        }
    }
}