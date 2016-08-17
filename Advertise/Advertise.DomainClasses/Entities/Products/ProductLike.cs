using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده انواع لایک
    /// </summary>
    public class ProduectLike : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     Like and Disliked
        /// </summary>
        public virtual bool IsLiked { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        ///     کد اختصاصی کاربری که لایک انجام داده
        /// </summary>
        public virtual User Liker { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid LikerId { get; set; }

        #endregion
    }
}