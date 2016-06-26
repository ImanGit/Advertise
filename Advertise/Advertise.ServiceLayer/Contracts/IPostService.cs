using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts
{
    /// <summary>
    /// نشان دهنده الزامات ارائه دهنده سرویس پست
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// درج پست جدید
        /// </summary>
        void Create();
    }
}
