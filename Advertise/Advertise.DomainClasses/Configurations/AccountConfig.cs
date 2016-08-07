using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;

namespace Advertise.DomainClasses.Configurations
{
     public  class AccountConfig :EntityTypeConfiguration< Account>
    {
         public AccountConfig()
         {
             ToTable("AD_Accounts");
             Property(accunt => accunt.Email).IsOptional().HasMaxLength(75);
            Property(accunt => accunt.Password).IsOptional();
             Property(accunt => accunt.UserName).IsRequired();
         }
    }
}
