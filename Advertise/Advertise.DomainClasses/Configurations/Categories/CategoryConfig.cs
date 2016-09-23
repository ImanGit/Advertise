using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Categories;

namespace Advertise.DomainClasses.Configurations.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        /// <summary>
        /// </summary>
        public CategoryConfig()
        {
            Property(category => category.Title).IsRequired().HasMaxLength(100);
            Property(category => category.Description).IsRequired().HasMaxLength(1000);
            Property(category => category.Code).IsOptional().HasMaxLength(100);
            //Property(category => category.RowVersion).IsRowVersion();
        }
    }
}