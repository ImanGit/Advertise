using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.DataLayer.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationDbContext : BaseDbContext, IUnitOfWork
    {
        /// <summary>
        /// 
        /// </summary>
        public ApplicationDbContext() : base("ApplicationConnection")
        {

        }
    }
}
