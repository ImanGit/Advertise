using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.DomainClasses.Entities.Companies ;
using Advertise.ViewModel.Models.Categories.CategoryFollow;
using Advertise.ViewModel.Models.Companies ;
using Advertise.ViewModel.Models.Companies .CompanyFollow ;
using AutoMapper;


namespace Advertise.Mapping.Profiles.Companies
{
    class CompanryFollowProfile : Profile
    {
        public CompanryFollowProfile()
        {

            CreateMap<CompanyFollow, CompanyFollowCreateViewModel>()
                .ProjectUsing(src => new CompanyFollowCreateViewModel
                {
                    IsFollow = src.IsFollow
                });
            CreateMap<CategoryFollowCreateViewModel, CategoryFollow>()
               .ForMember(dest => dest.IsFollow, opts => opts.MapFrom(src => src.IsFollow))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyFollow, CompanyFollowEditViewModel>()
                .ProjectUsing(src => new CompanyFollowEditViewModel
                {
                    IsFollow = src.IsFollow,
                     Id = src.Id
                });
            CreateMap<CompanyFollowEditViewModel, CompanyFollow>()
               .ForMember(dest => dest.IsFollow, opts => opts.MapFrom(src => src.IsFollow))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyFollow, CompanyFollowListViewModel >()
              .ProjectUsing(src => new CompanyFollowListViewModel
              {
                  IsFollow = src.IsFollow,
                  Id = src.Id
              });
            CreateMap<CompanyFollowListViewModel, CompanyFollow>()
               .ForMember(dest => dest.IsFollow, opts => opts.MapFrom(src => src.IsFollow))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}

