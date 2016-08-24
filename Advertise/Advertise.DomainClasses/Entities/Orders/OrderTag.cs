using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Plans
{
    /// <summary>
    /// </summary>
    public class Tag : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     sets or gets Tag's name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// </summary>
        public virtual string CostRialValue { get; set; }

        /// <summary>
        /// </summary>
        public virtual string DurationDay { get; set; }

        /// <summary>
        /// </summary>
        public virtual TagType Type { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime StartOn { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime ExpireOn { get; set; }

        #endregion

        #region NavigationProperties

        #endregion
    }
}