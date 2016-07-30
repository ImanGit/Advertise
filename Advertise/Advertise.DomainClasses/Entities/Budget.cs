using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده بودجه حساب مالی کاربر
    /// </summary>
    public class Budget : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Budget()
        {
            Id = Guid.NewGuid();
            Remain = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// بودجه باقی مانده حساب مالی کاربر
        /// </summary>
        public Int32 Remain { get; set; }

        /// <summary>
        /// افزایش و کاهش حساب مالی کاربر
        /// </summary>
        public Int32 IncDec { get; set; }

        /// <summary>
        /// کدرهگیری که بانک میدهد
        /// </summary>
        public string RefCode { get; set; }

        /// <summary>
        /// زمان انجام تغییر حساب مالی کاربری
        /// </summary>
        public DateTime RegisterDate { get; set; }

       
        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
