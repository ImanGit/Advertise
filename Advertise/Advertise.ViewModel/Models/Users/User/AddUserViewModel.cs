using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.User
{
    /// <summary>
    /// </summary>
    public class AddUserViewModel : BaseViewModel
    {
        #region Ctor

        /// <summary>
        /// </summary>
        public AddUserViewModel()
        {
            UserName = "";
        }

        #endregion

        #region Properties

        /// <summary>
        /// </summary>
        [DisplayName("نام کاربر")]
        [Required(ErrorMessage = "لطفا نام حود را وارد کنید")]
        [StringLength(50, ErrorMessage = "نام کاربر نباید از 50 حرف بیشتر باشد")]
        public string UserName { get; set; }

        #endregion
    }
}