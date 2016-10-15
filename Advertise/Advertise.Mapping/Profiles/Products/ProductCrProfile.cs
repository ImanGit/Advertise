using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Products ;
using Advertise.ViewModel.Models.Products.ProductCommentReport;

namespace Advertise.Mapping.Profiles.Products
{
    class ProductCrProfile : Profile
    {
        public ProductCrProfile()
        {

            CreateMap<ProductCommentReport , ProductCommentReportCreateViewModel >()
                .ProjectUsing(src => new ProductCommentReportCreateViewModel
                {

                    //Type  = src.Type 
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<ProductCommentReportCreateViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductCommentReport, ProductCommentReportEditViewModel >()
                .ProjectUsing(src => new ProductCommentReportEditViewModel
                {
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<ProductCommentReportEditViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductCommentReport, ProductCommentReportDetailViewModel >()
               .ProjectUsing(src => new ProductCommentReportDetailViewModel
               {
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<ProductCommentReportDetailViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductCommentReport, ProductCommentReportDeleteViewModel >()
              .ProjectUsing(src => new ProductCommentReportDeleteViewModel
              {
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<ProductCommentReportDeleteViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}
