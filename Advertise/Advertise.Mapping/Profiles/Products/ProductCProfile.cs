using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Advertise.DomainClasses.Entities.Products;
using Advertise.ViewModel.Models.Products.ProductComment;


namespace Advertise.Mapping.Profiles.Products
{
    class ProductCProfile : Profile
    {
        public ProductCProfile()
        {

            CreateMap<ProductComment, ProductCCreateViewModel>()
                .ProjectUsing(src => new ProductCCreateViewModel
                {
                    IsApproved =src.IsApproved ,
                    Body =src.Body ,
                    Status =src.Status  
                });
            CreateMap<ProductCCreateViewModel, ProductComment>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductComment, ProductCEditViewModel>()
                .ProjectUsing(src => new ProductCEditViewModel
                {
                    IsApproved = src.IsApproved,
                    Body = src.Body,
                    Status = src.Status,
                    Id = src.Id
                });
            CreateMap<ProductCEditViewModel, ProductComment>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductComment, ProductCDetailViewModel>()
               .ProjectUsing(src => new ProductCDetailViewModel
               {
                   IsApproved = src.IsApproved,
                   Body = src.Body,
                   Status = src.Status,
                   Id = src.Id
               });
            CreateMap<ProductCDetailViewModel, ProductComment>()
                .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductComment, ProductCDeleteViewModel>()
              .ProjectUsing(src => new ProductCDeleteViewModel
              {
                  IsApproved = src.IsApproved,
                  Body = src.Body,
                  Status = src.Status,
                  Id = src.Id
              });
            CreateMap<ProductCDeleteViewModel, ProductComment>()
                .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
