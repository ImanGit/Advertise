using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// نشان دهنده مپینگ مربوط به کلاس پست
    /// </summary>
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public PostConfig()
        {

        }
    }
}
