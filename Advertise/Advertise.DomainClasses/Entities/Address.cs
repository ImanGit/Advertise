using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Gps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Street { get; set; }
        /// <summary>
        ///     کد پستی شرکت
        /// </summary>
        public virtual string PostalCode { get; set; }

        /// <summary>
        ///     کد اختصاصی آدرس
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }
    }
}
