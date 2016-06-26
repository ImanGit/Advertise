using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Advertise.DataLayer.Context
{
    class BaseDbContext : DbContext
    {
        #region Ctor
        public BaseDbContext(string connectionString) : base(connectionString)
        {

        }
        #endregion
    }
}
