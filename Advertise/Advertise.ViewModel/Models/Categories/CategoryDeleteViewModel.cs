using System;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Categories
{
    public class CategoryDeleteViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        /// <summary>
        ///     عنوان دسته بندی
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     توضیحات دسته بندی
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        public string ImageFileName { get; set; }

        /// <summary>
        /// </summary>
        public string ParentPath { get; set; }

        /// <summary>
        /// </summary>
        public bool IsActive { get; set; }
    }
}