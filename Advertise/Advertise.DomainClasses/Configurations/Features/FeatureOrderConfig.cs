using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Features;

namespace Advertise.DomainClasses.Configurations.Features
{
    /// <summary>
    /// </summary>
    public class FeatureOrderConfig : EntityTypeConfiguration<FeatureOrder>
    {
        /// <summary>
        /// </summary>
        public FeatureOrderConfig()
        {
            Property(order => order.RowVersion).IsRowVersion();
        }
    }
}