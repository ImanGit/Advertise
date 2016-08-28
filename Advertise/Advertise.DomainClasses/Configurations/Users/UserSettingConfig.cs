using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserSettingConfig : EntityTypeConfiguration<UserSetting>
    {
        /// <summary>
        /// </summary>
        public UserSettingConfig()
        {
            Property(setting => setting.RowVersion).IsRowVersion();
        }
    }
}