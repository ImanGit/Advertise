using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    class CommentLikeConfig :EntityTypeConfiguration< ProductCommentLike >
    {
        public CommentLikeConfig()
        {
            Property(commentlike => commentlike.RowVersion ).IsRowVersion() ;
        }
    }
}
