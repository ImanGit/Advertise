using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.DomainClasses.Entities.Orders
{
    public enum OrderStatus
    {
        New,
        Hold,
        Shipped,
        Delivered,
        Closed
    }
}
