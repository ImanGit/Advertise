using System;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ViewModel.Models.Categories;
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
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    Title = src.Title,
                    ParentId = src.ParentId
                });
            CreateMap<CategoryReview, CategoryCreateViewModel>()
                .ProjectUsing(src => new CategoryCreateViewModel
                {
                    Body = src.Body
                    
                });

            CreateMap<CategoryCreateViewModel, Category>()
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageFileName, opts => opts.MapFrom(src => src.ImageFileName))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.ParentId, opts => opts.MapFrom(src => src.ParentId))
                .ForAllOtherMembers(opt => opt.Ignore())
                ;
            CreateMap<CategoryCreateViewModel, CategoryReview>()
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                //.ForMember(dest=>dest.AuthoredById,opts=>opts.MapFrom(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709")))
                .ForAllOtherMembers(opt => opt.Ignore())
                ;









            //.ProjectUsing(src => new Category
            //{
            //    Description = src.Description,
            //    ImageFileName = src.ImageFileName,
            //    Title = src.Title,
            //    ParentId = src.ParentId,
            //    Review. = 
            //});

            CreateMap<Category, CategoryListViewModel>()
                .ProjectUsing(src => new CategoryListViewModel
                {
                    Code = src.Code,
                    Description = src.Description,
                    ImageFileName = src.ImageFileName,
                    IsActive = src.IsActive,
                    Title = src.Title,
                    ParentPath = src.ParentPath,
                    Id = src.Id,
                    ParentId = src.ParentId
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
                    Id = src.Id,
                    ParentId = src.ParentId
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
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageFileName, opts => opts.MapFrom(src => src.ImageFileName))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.ParentPath, opts => opts.MapFrom(src => src.ParentPath))
                .ForAllOtherMembers(opt => opt.Ignore())
                ;

            CreateMap<Category, CategoryDeleteViewModel>()
               .ProjectUsing(src => new CategoryDeleteViewModel
               {
                   Code = src.Code,
                   Description = src.Description,
                   ImageFileName = src.ImageFileName,
                   IsActive = src.IsActive,
                   Title = src.Title,
                   ParentPath = src.ParentPath,
                   Id = src.Id
               });

            CreateMap<CategoryDeleteViewModel, Category>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.ImageFileName, opts => opts.MapFrom(src => src.ImageFileName))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                .ForMember(dest => dest.ParentPath, opts => opts.MapFrom(src => src.ParentPath))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Category, CategoryDetailsViewModel>()
               .ProjectUsing(src => new CategoryDetailsViewModel
               {
                   Code = src.Code,
                   Description = src.Description,
                   ImageFileName = src.ImageFileName,
                   IsActive = src.IsActive,
                   Title = src.Title,
                   ParentPath = src.ParentPath,
                   Id = src.Id
               });

            CreateMap<CategoryDetailsViewModel, Category>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
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