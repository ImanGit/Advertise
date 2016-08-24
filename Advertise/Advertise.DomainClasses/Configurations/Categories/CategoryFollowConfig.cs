using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Categories;

namespace Advertise.DomainClasses.Configurations.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryFollowConfig : EntityTypeConfiguration<CategoryFollow>
    {
        /// <summary>
        /// </summary>
        public CategoryFollowConfig()
        {
            Property(follow => follow.RowVersion).IsRowVersion();
        }
    }
}