using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده آدرس
    /// </summary>
    public class Place : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Place()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// استان
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// شهرستان
        /// </summary>
        public string  City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string  ParentId { get; set; }



        #endregion

        #region NavigationProperties

       

        #endregion
    }
}
