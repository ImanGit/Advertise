using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities
{
    public class UserClaim:IdentityUserClaim<Guid>
    {

    }
}
