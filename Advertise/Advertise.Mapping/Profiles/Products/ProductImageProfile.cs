using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.DomainClasses.Entities.Products;
using Advertise.ViewModel.Models.Products.ProductImage ;
using AutoMapper;


namespace Advertise.Mapping.Profiles.Products
{
    class ProductImageProfile : Profile
    {
        public ProductImageProfile()
        {

            CreateMap<ProductImage , ProductImageCreateViewModel >()
                .ProjectUsing(src => new ProductImageCreateViewModel
                {
                    FileName = src.FileName,
                    FileSize = src.FileSize,
                    FileDimension = src.FileDimension,
                    Order = src.Order

                });
            CreateMap<ProductImageCreateViewModel, ProductImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductImage, ProductImageEditViewModel>()
                .ProjectUsing(src => new ProductImageEditViewModel
                {
                    FileName = src.FileName,
                    FileSize = src.FileSize,
                    FileDimension = src.FileDimension,
                    Order = src.Order,
                    Id = src.Id
                });
            CreateMap<ProductImageEditViewModel, ProductImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductImage, ProductImageListViewModel>()
              .ProjectUsing(src => new ProductImageListViewModel
              {
                  FileName = src.FileName,
                  FileSize = src.FileSize,
                  FileDimension = src.FileDimension,
                  Order = src.Order,
                  Id = src.Id
              });
            CreateMap<ProductImageListViewModel, ProductImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductImage, ProductImageDetailViewModel>()
              .ProjectUsing(src => new ProductImageDetailViewModel
              {
                  FileName = src.FileName,
                  FileSize = src.FileSize,
                  FileDimension = src.FileDimension,
                  Order = src.Order

              });
            CreateMap<ProductImageDetailViewModel, ProductImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}



