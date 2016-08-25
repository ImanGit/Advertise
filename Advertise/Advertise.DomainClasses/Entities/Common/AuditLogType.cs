using System.ComponentModel.DataAnnotations;

namespace Advertise.DomainClasses.Entities.Common
{
    /// <summary>
    ///     نشان دهنده انواع علمیاتی است که میتواند انجام شود
    /// </summary>
    public enum AuditLogType
    {
        /// <summary>
        ///     درج رکود
        /// </summary>
        [Display(Name = "درج")] Create,

        /// <summary>
        ///     ویرایش
        /// </summary>
        [Display(Name = "ویرایش")] Update,

        /// <summary>
        ///     حذف فیزیکی
        /// </summary>
        [Display(Name = "حذف فیزیکی")] Delete,

        /// <summary>
        ///     حذف نرم
        /// </summary>
        [Display(Name = "حذف نرم")] SoftDelete
    }
}