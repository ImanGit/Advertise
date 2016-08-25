using System.ComponentModel.DataAnnotations;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// </summary>
    public enum CommentStatus
    {
        /// <summary>
        /// </summary>
        [Display(Name = "تأیید شده")] Approved = 1,

        /// <summary>
        /// </summary>
        [Display(Name = "در انتظار بررسی")] Pending = 2,

        /// <summary>
        /// </summary>
        [Display(Name = "جفنگ")] Spam = 3,

        /// <summary>
        /// </summary>
        [Display(Name = "زباله دان")] Trash = 4
    }
}