using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده مقادیر فیلدها
    /// </summary>
    public class Property : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Property()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string  Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid  ProductId { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Guid  PropertyTemplateId { get; set; }

     

        #endregion

        #region NavigationProperties


        #endregion
    }
}
