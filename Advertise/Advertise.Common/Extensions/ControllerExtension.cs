using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Advertise.Common.Noty;

namespace Advertise.Common.Extensions
{
    public static class ControllerExtension
    {
        #region Noty
        private static void AddNotyAlert(this ControllerBase controller, NotyMessage message)
        {
            var noty = controller.TempData.ContainsKey(Noty.Noty.TempDataKey)
                 ? (Noty.Noty)controller.TempData[Noty.Noty.TempDataKey]
                 : new Noty.Noty();

            noty.AddNotyMessage(message);

            controller.TempData[Noty.Noty.TempDataKey] = noty;
        }
        public static void NotySuccessModal(this ControllerBase controller, string message, bool isSticky = false, MessageLocationType location = MessageLocationType.Center)
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
            controller.AddNotyAlert(notyMessage);
        }
        public static void NotySuccess(this ControllerBase controller, string message, bool isSticky = false)
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
            controller.AddNotyAlert(notyMessage);
        }
        public static void NotyInformation(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Information,
                IsSticky = isSticky,
                Message = message
            };
            controller.AddNotyAlert(notyMessage);
        }

        public static void NotyWarning(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Warning,
                IsSticky = isSticky,
                Message = message
            };
            controller.AddNotyAlert(notyMessage);
        }

        public static void NotyError(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Error,
                IsSticky = isSticky,
                Message = message
            };
            controller.AddNotyAlert(notyMessage);
        }
        public static void NotyAlert(this ControllerBase controller, string message, bool isSticky = false)
        {
            var notyMessage = new NotyMessage
            {
                Type = AlertType.Alert,
                IsSticky = isSticky,
                Message = message
            };
            controller.AddNotyAlert(notyMessage);
        }

        #endregion
    }
}
