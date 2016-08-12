using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;

namespace Advertise.DomainClasses.Configurations
{
    class CommentLikeConfig :EntityTypeConfiguration< CommentLike >
    {
        public CommentLikeConfig()
        {
            Property(commentlike => commentlike.RowVersion ).IsRowVersion() ;
        }
    }
}
