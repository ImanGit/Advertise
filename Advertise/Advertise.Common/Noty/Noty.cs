using System;
using System.Collections.Generic;

namespace Advertise.Common.Noty
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class Noty
    {
        /// <summary>
        /// </summary>
        public const string TempDataKey = "TempDataNotyAlerts";

        /// <summary>
        /// </summary>
        private IList<NotyMessage> _notyMessages;

        /// <summary>
        /// </summary>
        public Noty()
        {
            NotyMessages = new List<NotyMessage>();
            MaxVisibleForQueue = 20;
        }

        /// <summary>
        /// </summary>
        public bool DismissQueue { get; set; }

        /// <summary>
        /// </summary>
        public int MaxVisibleForQueue { get; set; }

        /// <summary>
        /// </summary>
        public IList<NotyMessage> NotyMessages
        {
            get { return _notyMessages; }
            set { _notyMessages = value; }
        }

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public NotyMessage AddNotyMessage(NotyMessage message)
        {
            NotyMessages.Add(message);
            return message;
        }
    }
}