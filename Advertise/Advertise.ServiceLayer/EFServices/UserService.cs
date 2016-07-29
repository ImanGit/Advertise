using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts;
using Advertise.ServiceLayer.EFServices.Common;

namespace Advertise.ServiceLayer.EFServices
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : BaseService , IUserService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        public void Create()
        {

        }
        #endregion

        #region Count
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long Count()
        {
            return 0;
        }
        #endregion
    }
}
