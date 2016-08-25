using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    public class UserLoginConfig: EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfig()
        {
            HasKey(login => login.UserId);

        }
    }
}
