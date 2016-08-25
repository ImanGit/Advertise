using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class UserSocialConfig : EntityTypeConfiguration<UserSocial>
    {
        /// <summary>
        /// </summary>
        public UserSocialConfig()
        {
            //ToTable("AD_Social");

            Property(usersocial => usersocial.YoutubeLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.FacebookLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.TwitterLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.RowVersion).IsRowVersion();
        }
    }
}