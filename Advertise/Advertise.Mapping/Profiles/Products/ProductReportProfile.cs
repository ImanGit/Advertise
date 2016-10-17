using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Advertise.DomainClasses.Entities.Products ;
using Advertise.ViewModel.Models.Products  ;

namespace Advertise.Mapping.Profiles.Products
{
    class ProductReporteportProfile : Profile
    {
        public ProductReporteportProfile()
        {

            CreateMap<ProductReport, ProductReportCreateViewModel>()
                .ProjectUsing(src => new ProductReportCreateViewModel
                {

                    Type  = src.Type ,
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<ProductReportCreateViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReport, ProductReportEditViewModel>()
                .ProjectUsing(src => new ProductReportEditViewModel
                {
                    Type = src.Type,
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<ProductReportEditViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductReport, ProductReportDetailViewModel>()
               .ProjectUsing(src => new ProductReportDetailViewModel
               {
                   Type = src.Type,
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<ProductReportDetailViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReport, ProductReportDeleteViewModel>()
              .ProjectUsing(src => new ProductReportDeleteViewModel
              {
                  Type = src.Type,
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<ProductReportDeleteViewModel, ProductReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForMember(dest => dest.Type , opts => opts.MapFrom(src => src.Type))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
