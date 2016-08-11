using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Action : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Action()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsEnable { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Role Role { get; set; }

        #endregion
    }
}
