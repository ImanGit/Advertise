using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestionReport;

namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyQuestionReportProfile : Profile
    {
        public CompanyQuestionReportProfile()
        {

            CreateMap<CompanyQuestionReport , CompanyQrCreateViewModel >()
                .ProjectUsing(src => new CompanyQrCreateViewModel
                {

                    //Type  = src.Type 
                    Reason=src.Reason ,
                    IsRead =src.IsRead 
                });
            CreateMap<CompanyQrCreateViewModel, CompanyQuestionReport>()
               .ForMember(dest => dest.IsRead , opts => opts.MapFrom(src => src.IsRead ))
               .ForMember(dest => dest.Reason , opts => opts.MapFrom(src => src.Reason ))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestionReport, CompanyQrEditViewModel>()
                .ProjectUsing(src => new CompanyQrEditViewModel
                {
                    Reason = src.Reason,
                    IsRead = src.IsRead,
                    Id = src.Id
                });
            CreateMap<CompanyQrEditViewModel, CompanyQuestionReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanyQuestionReport, CompanyQrDetailViewModel >()
               .ProjectUsing(src => new CompanyQrDetailViewModel
               {
                   Reason = src.Reason,
                   IsRead = src.IsRead,
                   Id = src.Id
               });
            CreateMap<CompanyQrDetailViewModel, CompanyQuestionReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestionReport, CompanyQrDeleteViewModel >()
              .ProjectUsing(src => new CompanyQrDeleteViewModel
              {
                  Reason = src.Reason,
                  IsRead = src.IsRead,
                  Id = src.Id
              });
            CreateMap<CompanyQrDeleteViewModel, CompanyQuestionReport>()
               .ForMember(dest => dest.IsRead, opts => opts.MapFrom(src => src.IsRead))
               .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}



