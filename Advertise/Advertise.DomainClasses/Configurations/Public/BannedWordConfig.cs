using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class BannedWordConfig : EntityTypeConfiguration<BannedWord>
    {
        /// <summary>
        /// </summary>
        public BannedWordConfig()
        {
            Property(word => word.RowVersion).IsRowVersion();
        }
    }
}