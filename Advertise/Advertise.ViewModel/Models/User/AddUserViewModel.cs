using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.User
{
    /// <summary>
    /// 
    /// </summary>
    public class AddUserViewModel : BaseViewModel
    {
        #region Ctor

        public AddUserViewModel()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("نام کاربر")]
        [Required(ErrorMessage = "لطفا نام حود را وارد کنید")]
        [StringLength(maximumLength: 50, ErrorMessage = "نام کاربر نباید از 50 حرف بیشتر باشد")]
        public string UserName { get; set; }

        #endregion
    }
}
