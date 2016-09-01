using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class CityConfig : EntityTypeConfiguration<City>
    {
        /// <summary>
        /// </summary>
        public CityConfig()
        {
            Property(city => city.Name).IsRequired().HasMaxLength(100);
            Property(city => city.RowVersion).IsRowVersion();
        }
    }
}