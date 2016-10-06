using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ViewModel.Models.Categories;
using Advertise.ViewModel.Models.Categories.CategoryFollow;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Categories
{
    public class CategoryFollowProfile : Profile
    {
        public CategoryFollowProfile()
        {

            CreateMap<CategoryFollow, CategoryFollowCreateViewModel>()
                .ProjectUsing(src => new CategoryFollowCreateViewModel
                {
                    IsFollow = src.IsFollow
                });
            CreateMap<CategoryFollowCreateViewModel, CategoryFollow>()
               .ForMember(dest => dest.IsFollow, opts => opts.MapFrom(src => src.IsFollow))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CategoryFollow, CategoryFollowEditViewModel >()
                .ProjectUsing(src => new CategoryFollowEditViewModel
                {
                    IsFollow = src.IsFollow
                });
            CreateMap<CategoryFollowEditViewModel, CategoryFollow>()
               .ForMember(dest => dest.IsFollow, opts => opts.MapFrom(src => src.IsFollow))
               .ForAllOtherMembers(opt => opt.Ignore());



        }
    }
}
