using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Products ;
using Advertise.ViewModel.Models.Companies;
using Advertise.ViewModel.Models.Products .ProductCommentLike ;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Products
{
    class ProductClProfile : Profile
    {
        public ProductClProfile()
        {

            CreateMap<ProductCommentLike , ProductClCreateViewModel >()
                .ProjectUsing(src => new ProductClCreateViewModel
                {
                    IsLiked = src.IsLike 
                });
            CreateMap<ProductClCreateViewModel, ProductCommentLike>()
               .ForMember(dest => dest.IsLike, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductCommentLike, ProductClEditViewModel >()
                .ProjectUsing(src => new ProductClEditViewModel
                {
                    IsLiked = src.IsLike,
                    Id = src.Id
                });
            CreateMap<ProductClEditViewModel, ProductClEditViewModel>()
               .ForMember(dest => dest.IsLiked, opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());



        }
    }
}