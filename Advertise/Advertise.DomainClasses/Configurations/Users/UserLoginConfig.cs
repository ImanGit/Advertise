using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserLoginConfig : EntityTypeConfiguration<UserLogin>
    {
        /// <summary>
        /// </summary>
        public UserLoginConfig()
        {
            HasKey(login => login.UserId);
            Property(login => login.RowVersion).IsRowVersion();
        }
    }
}