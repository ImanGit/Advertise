using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// نشان دهنده مپینگ مربوط به کلاس کاربر
    /// </summary>
    public class UserConfig : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public UserConfig()
        {
            ToTable("AD_Users");

            Property(user => user.FirstName).IsOptional().HasMaxLength(50);
            Property(user => user.LastName).IsOptional().HasMaxLength(50);
            Property(user => user.Gender).IsRequired();
            Property(user => user.AvatarPath).IsOptional();
            Property(user => user.DisplayName).IsOptional().HasMaxLength(255);
            Property(user => user.RowVersion).IsRowVersion();

            HasMany(user => user.Notifications)
                .WithRequired(notification => notification.User)
                .WillCascadeOnDelete(true);
            HasMany(user => user.Products).WithRequired(product => product.User).WillCascadeOnDelete(true);
            HasMany(user => user.Accounts).WithRequired(account => account.User).WillCascadeOnDelete(true);
        }
    }
}
