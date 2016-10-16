using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies ;
using AutoMapper;


namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyModeratorProfile : Profile
    {
        public CompanyModeratorProfile()
        {

            CreateMap<CompanyModerator, CompanyModeratorCreateViewModel >()
                .ProjectUsing(src => new CompanyModeratorCreateViewModel
                {
                    IsActive  = src.IsActive 
                });
            CreateMap<CompanyModeratorCreateViewModel, CompanyModerator>()
               .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyModerator, CompanyModeratorEditViewModel>()
                .ProjectUsing(src => new CompanyModeratorEditViewModel
                {
                    IsActive = src.IsActive,
                    Id = src.Id
                });
            CreateMap<CompanyModeratorEditViewModel, CompanyModerator>()
               .ForMember(dest => dest.IsActive , opts => opts.MapFrom(src => src.IsActive ))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyModerator, CompanyModeratorListViewModel >()
              .ProjectUsing(src => new CompanyModeratorListViewModel
              {
                  IsActive = src.IsActive,
                  Id = src.Id
              });
            CreateMap<CompanyModeratorListViewModel, CompanyModerator>()
               .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
               .ForAllOtherMembers(opt => opt.Ignore());



            CreateMap<CompanyModerator, CompanyModeratorDetailViewModel >()
              .ProjectUsing(src => new CompanyModeratorDetailViewModel
              {
                  IsActive = src.IsActive,
                  Id = src.Id
              });
            CreateMap<CompanyModeratorDetailViewModel, CompanyModerator>()
               .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}

