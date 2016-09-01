using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyAttachmentConfig : EntityTypeConfiguration<CompanyAttachment>
    {
        /// <summary>
        /// </summary>
        public CompanyAttachmentConfig()
        {
            Property(attachment => attachment.FileName).IsRequired().HasMaxLength(100);
            Property(attachment => attachment.RowVersion).IsRowVersion();
        }
    }
}