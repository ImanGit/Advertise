using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Specifications;

namespace Advertise.DomainClasses.Configurations.Specifications
{
    /// <summary>
    /// </summary>
    public class SpecificationOptionConfig : EntityTypeConfiguration<SpecificationOption>
    {
        /// <summary>
        /// </summary>
        public SpecificationOptionConfig()
        {
            Property(option => option.Title).IsRequired().HasMaxLength(100);
            Property(option => option.RowVersion).IsRowVersion();
        }
    }
}