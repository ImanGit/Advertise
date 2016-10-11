using AutoMapper;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.DomainClasses.Entities.Products;
using Advertise.ViewModel.Models.Products.ProductReview ;

namespace Advertise.Mapping.Profiles.Products
{
    class ProductReviewProfile : Profile
    {
        public ProductReviewProfile()
        {

            CreateMap<ProductReview , ProductRwCreateViewModel>()
                .ProjectUsing(src => new ProductRwCreateViewModel
                {
                    Body = src.Body,
                    Active = src.IsActive,
                });
            CreateMap<ProductRwCreateViewModel, ProductReview>()
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReview, ProductRwDeleteViewModel>()
               .ProjectUsing(src => new ProductRwDeleteViewModel
               {
                   Body = src.Body,
                   Active = src.IsActive,
                   Id = src.Id
               });
            CreateMap<ProductRwDeleteViewModel, ProductReview>()
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReview, ProductRwDetailViewModel>()
               .ProjectUsing(src => new ProductRwDetailViewModel
               {
                   Body = src.Body,
                   Active = src.IsActive ,
                   Id = src.Id
               });
            CreateMap<ProductRwEditViewModel, ProductReview>()
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductReview, ProductRwListViewModel>()
               .ProjectUsing(src => new ProductRwListViewModel
               {
                   Body = src.Body,
                   Active =src.IsActive,
                   Id = src.Id
               });
            CreateMap<ProductRwListViewModel, ProductReview>()
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}