using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Roles;

namespace Advertise.DomainClasses.Configurations.Roles
{
    /// <summary>
    /// </summary>
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        /// <summary>
        /// </summary>
        public RoleConfig()
        {
            Property(role => role.Code).IsRequired().HasMaxLength(100);
            Property(role => role.Name).IsRequired().HasMaxLength(100);
            Property(role => role.RowVersion).IsRowVersion();
        }
    }
}