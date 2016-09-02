using Advertise.DomainClasses.Entities.Categories;
using Advertise.ViewModel.Models.Categories.Category;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryProfile : Profile
    {
        /// <summary>
        /// </summary>
        public CategoryProfile()
        {
            CreateMap<Category, CategoryCreateViewModel>()
                .ProjectUsing(src => new CategoryCreateViewModel
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath
                });
                //.ForMember(d => d.CreatorUserName, opt => opt.MapFrom(src => src.CreatedBy.UserName))
                //.ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CategoryCreateViewModel, Category>()
                .ProjectUsing(src => new Category
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath
                });
            //.ForAllOtherMembers(opt => opt.Ignore());
        }

      
        /// <summary>
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}