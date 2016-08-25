using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    public class UserLoginConfig : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfig()
        {
            HasKey(login => login.UserId);
        }
    }
}