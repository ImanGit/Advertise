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

            CreateMap<ProductComment, ProductCommentCreateViewModel>()
                .ProjectUsing(src => new ProductCommentCreateViewModel
                {
                    IsApproved =src.IsApproved ,
                    Body =src.Body ,
                    Status =src.Status  
                });
            CreateMap<ProductCommentCreateViewModel, ProductComment>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductComment, ProductCommentEditViewModel>()
                .ProjectUsing(src => new ProductCommentEditViewModel
                {
                    IsApproved = src.IsApproved,
                    Body = src.Body,
                    Status = src.Status,
                    Id = src.Id
                });
            CreateMap<ProductCommentEditViewModel, ProductComment>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<ProductComment, ProductCommentDetailViewModel>()
               .ProjectUsing(src => new ProductCommentDetailViewModel
               {
                   IsApproved = src.IsApproved,
                   Body = src.Body,
                   Status = src.Status,
                   Id = src.Id
               });
            CreateMap<ProductCommentDetailViewModel, ProductComment>()
                .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductComment, ProductCommentDeleteViewModel>()
              .ProjectUsing(src => new ProductCommentDeleteViewModel
              {
                  IsApproved = src.IsApproved,
                  Body = src.Body,
                  Status = src.Status,
                  Id = src.Id
              });
            CreateMap<ProductCommentDeleteViewModel, ProductComment>()
                .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
               .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
