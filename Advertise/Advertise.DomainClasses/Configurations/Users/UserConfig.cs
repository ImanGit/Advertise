using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserConfig : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// </summary>
        public UserConfig()
        {
            Property(user => user.Email).IsOptional().HasMaxLength(100);
            Property(user => user.UserName).IsRequired().HasMaxLength(100);
            Property(user => user.PhoneNumber).IsOptional().HasMaxLength(10);
            Property(user => user.RowVersion).IsRowVersion();
        }
    }
}