using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class PropertyConfig : EntityTypeConfiguration<ProductProperty>
    {
        /// <summary>
        /// 
        /// </summary>
        public PropertyConfig()
        {
            //ToTable("AD_Property");

            Property(property => property.Value).IsRequired().HasMaxLength(100);
            Property(property => property.RowVersion).IsRowVersion();
        }
    }
}
