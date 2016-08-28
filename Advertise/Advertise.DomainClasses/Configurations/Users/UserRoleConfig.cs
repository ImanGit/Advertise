using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        /// <summary>
        /// </summary>
        public UserRoleConfig()
        {
            HasKey(role => role.RoleId);
            Property(role => role.RowVersion).IsRowVersion();
        }
    }
}