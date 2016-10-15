using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Advertise.DomainClasses.Entities.Products ;
using Advertise.ViewModel.Models.Products .ProductReport ;

namespace Advertise.Mapping.Profiles.Products
{
    class ProductReportProfile : Profile
    {
        public ProductReportProfile()
        {

            CreateMap<ProductReport, ProductRCreateViewModel>()
                .ProjectUsing(src => new ProductRCreateViewModel
                {

                    Type  = src.Type ,
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<ProductRCreateViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReport, ProductREditViewModel>()
                .ProjectUsing(src => new ProductREditViewModel
                {
                    Type = src.Type,
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<ProductREditViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductReport, ProductRDetailViewModel>()
               .ProjectUsing(src => new ProductRDetailViewModel
               {
                   Type = src.Type,
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<ProductRDetailViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReport, ProductRDeleteViewModel>()
              .ProjectUsing(src => new ProductRDeleteViewModel
              {
                  Type = src.Type,
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<ProductRDeleteViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForMember(dest => dest.Type , opts => opts.MapFrom(src => src.Type))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
