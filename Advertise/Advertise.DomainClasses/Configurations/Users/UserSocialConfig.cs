using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserSocialConfig : EntityTypeConfiguration<UserSocial>
    {
        /// <summary>
        /// </summary>
        public UserSocialConfig()
        {
            Property(social => social.YoutubeLink).IsOptional().HasMaxLength(100);
            Property(social => social.FacebookLink).IsOptional().HasMaxLength(100);
            Property(social => social.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(social => social.TwitterLink).IsOptional().HasMaxLength(100);
            Property(social => social.RowVersion).IsRowVersion();
        }
    }
}