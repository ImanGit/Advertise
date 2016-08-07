using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class SocialConfig : EntityTypeConfiguration<Social>
    {
        /// <summary>
        /// 
        /// </summary>
        public SocialConfig()
        {
            //ToTable("AD_Social");

            Property(social => social.AparatLink).IsOptional().HasMaxLength(100);
            Property(social => social.FacebookLink).IsOptional().HasMaxLength(100);
            Property(social => social.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(social => social.TwitterLink).IsOptional().HasMaxLength(100);
            Property(social => social.RowVersion).IsRowVersion();
        }
    }
}
