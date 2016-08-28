using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Specifications;

namespace Advertise.DomainClasses.Configurations.Specifications
{
    /// <summary>
    /// </summary>
    public class SpecificationConfig : EntityTypeConfiguration<Specification>
    {
        /// <summary>
        /// </summary>
        public SpecificationConfig()
        {
            Property(specification => specification.Title).IsRequired().HasMaxLength(100);
            Property(specification => specification.RowVersion).IsRowVersion();
        }
    }
}