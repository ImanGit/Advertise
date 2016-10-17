namespace Advertise.ViewModel.Models.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseViewModel : ViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] RowVersion { get; set; }
    }
}