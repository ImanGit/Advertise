using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    ///     نشان دهنده مپینگ مربوط به کلاس کاربر
    /// </summary>
    public class ProfileConfig : EntityTypeConfiguration<UserProfile>
    {
        /// <summary>
        ///     سازنده پیش فرض
        /// </summary>
        public ProfileConfig()
        {
            //ToTable("AD_Users");

       
            Property(user => user.IsActive).IsRequired();
     
            Property(user => user.RowVersion).IsRowVersion();

            //HasMany(user => user.Accounts)
            //    .WithRequired(account => account.User)
            //    .HasForeignKey(account => account.UserId)
            //    .WillCascadeOnDelete(true);
            //HasMany(user => user.Budgets).WithRequired(budget => budget.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Comments).WithRequired(comment => comment.CreateUser).WillCascadeOnDelete(false);
            ////HasMany(user => user.Comments).WithOptional(comment => comment.AcceptUser).WillCascadeOnDelete(false);
            //HasMany(user => user.Companies).WithRequired(company => company.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Follows).WithRequired(follow => follow.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Likes).WithRequired(like => like.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Logs).WithRequired(log => log.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Messages).WithRequired(message => message.FromUser).WillCascadeOnDelete(true);
            //HasMany(user => user.Messages).WithRequired(message => message.ToUser).WillCascadeOnDelete(true);
            //HasMany(user => user.Notices).WithRequired(notice => notice.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Notifications)
            //    .WithRequired(notification => notification.User)
            //    .WillCascadeOnDelete(true);
            //HasMany(user => user.Payments).WithRequired(payment => payment.User).WillCascadeOnDelete(true);
            //HasMany(user => user.Products).WithRequired(product => product.CreateUser).WillCascadeOnDelete(false);
            ////HasMany(user => user.Products).WithOptional(product => product.AcceptUser).WillCascadeOnDelete(false);
            //HasMany(user => user.Questions)
            //    .WithRequired(question => question.User)
            //    .WillCascadeOnDelete(true);
            //HasMany(user => user.Settings).WithRequired(setting => setting.User).WillCascadeOnDelete(true);
        }
    }
}