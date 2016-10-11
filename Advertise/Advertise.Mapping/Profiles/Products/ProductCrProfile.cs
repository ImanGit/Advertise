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

            CreateMap<ProductCommentReport , ProductCrCreateViewModel >()
                .ProjectUsing(src => new ProductCrCreateViewModel
                {

                    //Type  = src.Type 
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<ProductCrCreateViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductCommentReport, ProductCrEditViewModel >()
                .ProjectUsing(src => new ProductCrEditViewModel
                {
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<ProductCrEditViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductCommentReport, ProductCrDetailViewModel >()
               .ProjectUsing(src => new ProductCrDetailViewModel
               {
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<ProductCrDetailViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductCommentReport, ProductCrDeleteViewModel >()
              .ProjectUsing(src => new ProductCrDeleteViewModel
              {
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<ProductCrDeleteViewModel, ProductCommentReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}
