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
            ToTable(tableName: "AD_Users");

            Property(d => d.FirstName).IsOptional().HasMaxLength(20);

            Property(c => c.Gender).HasColumnName("User_Gender");

            Property(c => c.Avatar).IsOptional().HasColumnName("User_AvatarPath");

            Property(c => c.DisplayName).IsOptional().HasMaxLength(255).HasColumnName("User_DisplayName");



            HasMany(c=>c.Notifications).WithRequired(d=>d.User).WillCascadeOnDelete();

            //HasKey(f => f.Id);




            //Hasop(c=>c.Notifications).WithMany().HasForeignKey(d=>d.)

        }
    }
}
