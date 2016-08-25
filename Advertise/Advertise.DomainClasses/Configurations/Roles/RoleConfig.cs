using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Roles;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        /// <summary>
        /// </summary>
        public RoleConfig()
        {
            //ToTable("AD_Role");

            Property(role => role.Code).IsRequired().HasMaxLength(50);
            Property(role => role.Name).IsRequired();
            Property(role => role.RowVersion).IsRowVersion();
        }
    }
}