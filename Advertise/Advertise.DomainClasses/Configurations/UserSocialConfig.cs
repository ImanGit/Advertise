using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class UserSocialConfig : EntityTypeConfiguration<CompanySocial>
    {
        /// <summary>
        /// 
        /// </summary>
        public UserSocialConfig()
        {
            //ToTable("AD_Social");

            Property(usersocial => usersocial.AparatLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.FacebookLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.GooglePlusLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.TwitterLink).IsOptional().HasMaxLength(100);
            Property(usersocial => usersocial.RowVersion).IsRowVersion();
        }
    }
}

