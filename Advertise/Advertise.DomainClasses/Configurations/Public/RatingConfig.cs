using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class RatingConfig : EntityTypeConfiguration<Rating>
    {
        /// <summary>
        /// </summary>
        public RatingConfig()
        {
            Property(rating => rating.RowVersion).IsRowVersion();
        }
    }
}