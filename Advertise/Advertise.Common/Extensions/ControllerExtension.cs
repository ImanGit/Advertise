using System.Web.Mvc;
using Advertise.Common.Noty;
using Microsoft.AspNet.Identity;

namespace Advertise.Common.Extensions
{
    /// <summary>
    /// </summary>
    public static class ControllerExtension
    {
        #region AlertMessage

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        private static void AddAlertMessage(this ControllerBase controller, NotyMessage message)
        {
            var noty = controller.TempData.ContainsKey(Noty.Noty.TempDataKey)
                ? (Noty.Noty) controller.TempData[Noty.Noty.TempDataKey]
                : new Noty.Noty();

            noty.AddNotyMessage(message);

            controller.TempData[Noty.Noty.TempDataKey] = noty;
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        /// <param name="isSticky"></param>
        /// <param name="location"></param>
        public static void ShowSuccessMessageModal(this ControllerBase controller, string message, bool isSticky = false,
            MessageLocationType location = MessageLocationType.Center)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Success,
                IsSticky = isSticky,
                Message = message,
                Location = location,
                CloseAnimation = AnimationType.BounceIn,
                OpenAnimation = AnimationType.BounceOut,
                IsModal = true,
                CloseWith = MessageCloseType.Click
            };

            controller.AddAlertMessage(notyMessage);
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        /// <param name="isSticky"></param>
        public static void ShowSuccessMessage(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Success,
                IsSticky = isSticky,
                Message = message,
                CloseWith = MessageCloseType.Click,
                Location = MessageLocationType.TopLeft,
                CloseAnimation = AnimationType.BounceOut,
                OpenAnimation = AnimationType.Bounce,
                IsModal = true
            };

            controller.AddAlertMessage(notyMessage);
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        /// <param name="isSticky"></param>
        public static void ShowInformationMessage(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Information,
                IsSticky = isSticky,
                Message = message
            };

            controller.AddAlertMessage(notyMessage);
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        /// <param name="isSticky"></param>
        public static void ShowWarningMessage(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Warning,
                IsSticky = isSticky,
                Message = message
            };

            controller.AddAlertMessage(notyMessage);
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="message"></param>
        /// <param name="isSticky"></param>
        public static void ShowErrorMessage(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Error,
                IsSticky = isSticky,
                Message = message
            };

            controller.AddAlertMessage(notyMessage);
        }

        public static void ShowAlertMessage(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Alert,
                IsSticky = isSticky,
                Message = message
            };

            controller.AddAlertMessage(notyMessage);
        }

        #endregion

        #region AddError

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="result"></param>
        public static void AddErrors(this System.Web.Mvc.Controller controller, IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                controller.ModelState.AddModelError("", error);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="property"></param>
        /// <param name="error"></param>
        public static void AddErrors(this System.Web.Mvc.Controller controller, string property, string error)
        {
            controller.ModelState.AddModelError(property, error);
        }

        #endregion
    }
}