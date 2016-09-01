using System;

namespace Advertise.Common.Noty
{
    [Serializable]
    public class NotyMessage
    {
        public AlertType Type { get; set; }
        public string Message { get; set; }
        public AnimationType CloseAnimation { get; set; }
        public AnimationType OpenAnimation { get; set; }
        public int AnimateSpeed { get; set; }
        /// <summary>
        /// gets or sets value indicating whether this message hast timeout(false) 
        /// </summary>
        public bool IsSticky { get; set; }
        public MessageCloseType CloseWith { get; set; }
        public MessageLocationType Location { get; set; }
        public bool IsSwing { get; set; }
        public bool IsKiller { get; set; }
        public bool IsForce { get; set; }
        public bool IsModal { get; set; }
    }
}