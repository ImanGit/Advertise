using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    public class Setting : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Setting()
        {
            Id = Guid.NewGuid();

        }

        #endregion

        #region Properties

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public Guid  Userid { get; set; }

        /// <summary>
        /// زبان انتخابی کاربر
        /// </summary>
        public int  Language { get; set; }

        /// <summary>
        /// تم انتخابی کاربر
        /// </summary>
        public int Theme { get; set; }

      

        #endregion

        #region NavigationProperties


        #endregion
    }
}
