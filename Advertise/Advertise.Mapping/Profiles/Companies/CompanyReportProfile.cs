using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyReport ;


namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyReportProfile : Profile
    {
        public CompanyReportProfile()
        {

            CreateMap<CompanyReport, CompanyReportCreateViewModel>()
                .ProjectUsing(src => new CompanyReportCreateViewModel
                {

                    Type  = src.Type ,
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<CompanyReportCreateViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReport, CompanyReportEditViewModel>()
                .ProjectUsing(src => new CompanyReportEditViewModel
                {
                    Type = src.Type,
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<CompanyReportEditViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanyReport, CompanyReportDetailViewModel>()
               .ProjectUsing(src => new CompanyReportDetailViewModel
               {
                   Type = src.Type,
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<CompanyReportDetailViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReport, CompanyReportDeleteViewModel>()
              .ProjectUsing(src => new CompanyReportDeleteViewModel
              {
                  Type = src.Type,
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<CompanyReportDeleteViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Type , opts => opts.MapFrom(src => src.Type))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
