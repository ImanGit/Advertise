using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Tags;

namespace Advertise.DomainClasses.Configurations.Tags
{
    /// <summary>
    /// </summary>
    public class TagOrderConfig : EntityTypeConfiguration<TagOrder>
    {
        /// <summary>
        /// </summary>
        public TagOrderConfig()
        {
            Property(order => order.RowVersion).IsRowVersion();
        }
    }
}