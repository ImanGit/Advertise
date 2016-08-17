using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingConfig : EntityTypeConfiguration<UserSetting>
    {
        /// <summary>
        /// 
        /// </summary>
        public SettingConfig()
        {
            //ToTable("AD_Setting");

            Property(setting => setting.Language).IsOptional();
            Property(setting => setting.Theme).IsOptional();
            Property(setting => setting.RowVersion).IsRowVersion();
        }
    }
}
