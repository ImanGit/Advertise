using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class QuestionConfig : EntityTypeConfiguration<CompanyQuestion>
    {
        /// <summary>
        /// </summary>
        public QuestionConfig()
        {
            //ToTable("AD_Qustion");

            Property(question => question.Content).IsRequired().HasMaxLength(700);
            Property(question => question.CreateDate).IsRequired();
            Property(question => question.IsAccepted).IsRequired();
            Property(question => question.LikedCount).IsOptional();
            Property(question => question.Title).IsRequired().HasMaxLength(255);
            Property(question => question.RowVersion).IsRowVersion();

            // Self Referencing Entity
            //HasOptional(question => question.Reply).WithMany().WillCascadeOnDelete(true);
        }
    }
}