using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class StatisticConfig : EntityTypeConfiguration<Statistic>
    {
        /// <summary>
        /// 
        /// </summary>
        public StatisticConfig()
        {
            ToTable("AD_Statistics");

            Property(statistic => statistic.Browser).IsRequired();
            Property(statistic => statistic.Date).IsRequired();
            Property(statistic => statistic.Ip).IsRequired();
            Property(statistic => statistic.Keyword).IsOptional();
            Property(statistic => statistic.SearchEngine).IsOptional();
        }
    }
}
