using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestionConfig : EntityTypeConfiguration<Question>
    {
        /// <summary>
        /// 
        /// </summary>
        public QuestionConfig()
        {
            ToTable("AD_Qustion");

            Property(question => question.Content).IsRequired().HasMaxLength(700);
            Property(question => question.CreateDate).IsRequired();
            Property(question => question.IsAccepted).IsRequired();
            Property(question => question.LikedCount).IsOptional();
            Property(question => question.Title).IsRequired().HasMaxLength(255);
            Property(question => question.RowVersion).IsRowVersion();

            HasMany(question => question.Questions).WithOptional(question => question.Reply).WillCascadeOnDelete(true);
        }
    }
}
