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
    class CompanryQuestionLikeProfile : Profile
    {
        public CompanryQuestionLikeProfile()
        {

            CreateMap<CompanyQuestionLike , CompanyQuestionLikeCreateViewModel >()
                .ProjectUsing(src => new CompanyQuestionLikeCreateViewModel
                {
                    IsLiked  = src.IsLiked
                });
            CreateMap<CompanyQuestionLikeCreateViewModel, CompanyQuestionLike>()
               .ForMember(dest => dest.IsLiked, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestionLike, CompanyQuestionLikeEditViewModel>()
                .ProjectUsing(src => new CompanyQuestionLikeEditViewModel
                {
                    IsLiked = src.IsLiked,
                    Id = src.Id
                });
            CreateMap<CompanyQuestionLikeEditViewModel, CompanyQuestionLike>()
               .ForMember(dest => dest.IsLiked, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

           

        }
    }
}


