using System.Data.Entity.ModelConfiguration;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class PropertyTemplateConfig : EntityTypeConfiguration<PropertyTemplate>
    {
        /// <summary>
        /// </summary>
        public PropertyTemplateConfig()
        {
            //ToTable("AD_PropertyTemplate");

            Property(propertTemplate => propertTemplate.Property).IsRequired();
            Property(propertyTemplate => propertyTemplate.Title).IsRequired().HasMaxLength(50);
            Property(propertyTemplate => propertyTemplate.RowVersion).IsRowVersion();
        }
    }
}