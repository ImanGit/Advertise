using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Categories
{
    public class CategoryCreateViewModel : BaseViewModel
    {

        [DisplayName("کد شناسه")]
        [Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        [StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Code { get; set; }

        /// <summary>
        ///     عنوان دسته بندی
        /// </summary>
        [DisplayName("عنوان")]
        public string Title { get; set; }

        /// <summary>
        ///     توضیحات دسته بندی
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "لطفا توضیحات را وارد کنید")]
        [DisplayName("توضیح")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [DisplayName("نام فایل")]
        public string ImageFileName { get; set; }

        /// <summary>
        /// </summary>
        [DisplayName("مسیر")]
        public string ParentPath { get; set; }

        /// <summary>
        /// </summary>
        [DisplayName("فعال")]
        public bool IsActive { get; set; }
    }
}