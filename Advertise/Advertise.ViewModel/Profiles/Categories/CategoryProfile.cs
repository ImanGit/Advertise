using Advertise.DomainClasses.Entities.Categories;
using Advertise.ViewModel.Models.Categories.Category;
using AutoMapper;

namespace Advertise.ViewModel.Profiles.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryProfile : Profile
    {
        /// <summary>
        /// </summary>
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewModel>()
                .ForMember(d => d.CreatorUserName, opt => opt.MapFrom(src => src.CreatedBy.UserName));

            CreateMap<CategoryViewModel, Category>();
        }

        /// <summary>
        /// 
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}