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

            CreateMap<Category, CategoryListViewModel>()
                .ProjectUsing(src => new CategoryListViewModel
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath,
                    Id = src.Id
                });

            CreateMap<CategoryListViewModel, Category>()
                .ProjectUsing(src => new Category
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath,
                    Id = src.Id
                });

            CreateMap<Category, CategoryEditViewModel>()
                .ProjectUsing(src => new CategoryEditViewModel
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath,
                    Id = src.Id
                });

            CreateMap<CategoryEditViewModel, Category>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description,opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageFileName, opts => opts.MapFrom(src => src.ImageFileName))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.ParentPath, opts => opts.MapFrom(src => src.ParentPath))
                .ForAllOtherMembers(opt => opt.Ignore());
        }

        /// <summary>
        /// </summary>
        public override string ProfileName => GetType().Name;
    }
}