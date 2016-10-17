using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    ///     نشان دهنده مپینگ مربوط به کلاس کاربر
    /// </summary>
    public class UserMetaConfig : EntityTypeConfiguration<UserMeta>
    {
        /// <summary>
        ///     سازنده پیش فرض
        /// </summary>
        public UserMetaConfig()
        {
            Property(user => user.AboutMe).IsOptional().HasMaxLength(1000);
            Property(user => user.RowVersion).IsRowVersion();
        }
    }
}