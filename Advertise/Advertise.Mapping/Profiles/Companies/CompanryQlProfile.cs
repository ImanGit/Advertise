using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestionLike ;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Companies
{
    class CompanryQlProfile : Profile
    {
        public CompanryQlProfile()
        {

            CreateMap<CompanyQuestionLike , CompanyQlCreateViewModel>()
                .ProjectUsing(src => new CompanyQlCreateViewModel
                {
                    IsLiked  = src.IsLiked
                });
            CreateMap<CompanyQlCreateViewModel, CompanyQuestionLike>()
               .ForMember(dest => dest.IsLiked, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestionLike, CompanyQlEditViewModel>()
                .ProjectUsing(src => new CompanyQlEditViewModel
                {
                    IsLiked = src.IsLiked,
                    Id = src.Id
                });
            CreateMap<CompanyQlEditViewModel, CompanyQuestionLike>()
               .ForMember(dest => dest.IsLiked, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

           

        }
    }
}


