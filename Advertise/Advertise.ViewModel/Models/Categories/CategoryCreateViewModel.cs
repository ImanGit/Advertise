using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Categories
{
    public class CategoryCreateViewModel : BaseViewModel
    {
        /// <summary>
        /// </summary>
        [DisplayName("دسته")]
        //[Required(ErrorMessage = "لطفا دسته را انتخاب کنید")]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// </summary>
        [DisplayName("بررسی")]
        [AllowHtml]
        public string Body { get; set; }

        /// <summary>
        ///     عنوان دسته بندی
        /// </summary>
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "لطفا عنوان را انتخاب کنید")]
        public string Title { get; set; }

        /// <summary>
        ///     توضیحات دسته بندی
        /// </summary>
        [DisplayName("توضیح")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [DisplayName("فایل")]
        public string ImageFileName { get; set; }
    }
}