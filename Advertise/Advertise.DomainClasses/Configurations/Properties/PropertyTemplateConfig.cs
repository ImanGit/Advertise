using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Properties;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class PropertyTemplateConfig : EntityTypeConfiguration<Property>
    {
        /// <summary>
        /// </summary>
        public PropertyTemplateConfig()
        {
            //ToTable("AD_PropertyTemplate");


            Property(propertyTemplate => propertyTemplate.Title).IsRequired().HasMaxLength(50);
            Property(propertyTemplate => propertyTemplate.RowVersion).IsRowVersion();
        }
    }
}