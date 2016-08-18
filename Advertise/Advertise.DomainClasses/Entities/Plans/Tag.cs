using System;

namespace Advertise.DomainClasses.Entities.Plans
{
    public class Tag
    {
        #region Properties

        /// <summary>
        ///     sets or gets Tag's identifier
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        ///     sets or gets Tag's name
        /// </summary>
        public virtual string Name { get; set; }

        #endregion
    }
}