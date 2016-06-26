using System.ComponentModel.DataAnnotations;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// انواع جنسیت
    /// </summary>
    public enum GenderType
    {
        /// <summary>
        /// مذکر
        /// </summary>
        [Display(Name ="مرد")]
        Male,

        /// <summary>
        /// مونث
        /// </summary>
        [Display(Name ="زن")]
        Female
    }
}
