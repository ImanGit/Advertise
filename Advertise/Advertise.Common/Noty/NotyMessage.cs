using System;

namespace Advertise.Common.Noty
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class NotyMessage
    {
        /// <summary>
        /// </summary>
        public AlertType Type { get; set; }

        /// <summary>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        public AnimationType CloseAnimation { get; set; }

        /// <summary>
        /// </summary>
        public AnimationType OpenAnimation { get; set; }

        /// <summary>
        /// </summary>
        public int AnimateSpeed { get; set; }

        /// <summary>
        ///     gets or sets value indicating whether this message hast timeout(false)
        /// </summary>
        public bool IsSticky { get; set; }

        /// <summary>
        /// </summary>
        public MessageCloseType CloseWith { get; set; }

        /// <summary>
        /// </summary>
        public MessageLocationType Location { get; set; }

        /// <summary>
        /// </summary>
        public bool IsSwing { get; set; }

        /// <summary>
        /// </summary>
        public bool IsKiller { get; set; }

        /// <summary>
        /// </summary>
        public bool IsForce { get; set; }

        /// <summary>
        /// </summary>
        public bool IsModal { get; set; }
    }
}