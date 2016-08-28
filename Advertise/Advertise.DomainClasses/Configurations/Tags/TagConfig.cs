using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Tags;

namespace Advertise.DomainClasses.Configurations.Tags
{
    /// <summary>
    /// </summary>
    public class TagConfig : EntityTypeConfiguration<Tag>
    {
        /// <summary>
        /// </summary>
        public TagConfig()
        {
            Property(tag => tag.Code).IsRequired().HasMaxLength(100);
            Property(tag => tag.RowVersion).IsRowVersion();
        }
    }
}