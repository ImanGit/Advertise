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
    class CompanyRProfile : Profile
    {
        public CompanyRProfile()
        {

            CreateMap<CompanyReport, CompanyRCreateViewModel>()
                .ProjectUsing(src => new CompanyRCreateViewModel
                {

                    //Type  = src.Type 
                    Reason = src.Reason,
                    IsRead = src.IsRead
                });
            CreateMap<CompanyRCreateViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReport, CompanyREditViewModel>()
                .ProjectUsing(src => new CompanyREditViewModel
                {
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<CompanyREditViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanyReport, CompanyRDetailViewModel>()
               .ProjectUsing(src => new CompanyRDetailViewModel
               {
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<CompanyRDetailViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReport, CompanyRDeleteViewModel>()
              .ProjectUsing(src => new CompanyRDeleteViewModel
              {
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<CompanyRDeleteViewModel, CompanyReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
