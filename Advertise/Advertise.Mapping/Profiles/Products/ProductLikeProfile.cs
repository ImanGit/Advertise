using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Products ;
using Advertise.ViewModel.Models.Companies;
using Advertise.ViewModel.Models.Products.ProductLike ;
using AutoMapper;


namespace Advertise.Mapping.Profiles.Products
{
    class ProductLikeProfile : Profile
    {
        public ProductLikeProfile()
        {

            CreateMap<ProductLike , ProductLikeCreateViewModel >()
                .ProjectUsing(src => new ProductLikeCreateViewModel
                {
                    IsLiked  = src.IsLike 
                });
            CreateMap<ProductLikeCreateViewModel, ProductLike>()
               .ForMember(dest => dest.IsLike , opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<ProductLike, ProductLikeEditViewModel>()
                .ProjectUsing(src => new ProductLikeEditViewModel
                {
                    IsLiked = src.IsLike ,
                    Id = src.Id
                });
            CreateMap<ProductLikeEditViewModel, ProductLike>()
               .ForMember(dest => dest.IsLike , opts => opts.MapFrom(src => src.IsLiked))
               .ForAllOtherMembers(opt => opt.Ignore());



        }
    }
}
