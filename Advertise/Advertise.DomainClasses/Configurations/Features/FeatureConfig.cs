using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Features;

namespace Advertise.DomainClasses.Configurations.Features
{
    /// <summary>
    /// </summary>
    public class FeatureConfig : EntityTypeConfiguration<Feature>
    {
        /// <summary>
        /// </summary>
        public FeatureConfig()
        {
            Property(feature => feature.Code).IsRequired().HasMaxLength(100);
            Property(feature => feature.RowVersion).IsRowVersion();
        }
    }
}