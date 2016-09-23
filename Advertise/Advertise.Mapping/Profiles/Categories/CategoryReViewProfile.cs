using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ViewModel.Models.Categories;
using Advertise.ViewModel.Models.Categories.CategoryReview;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Categories
{
   public  class CategoryReViewProfile :Profile 
    {
       public CategoryReViewProfile()
       {
           CreateMap<CategoryReview, CategoryReviewCreateViewModel>()
               .ProjectUsing(src => new CategoryReviewCreateViewModel
               {
                   Body =src.Body ,
                   IsActive =src.IsActive 
               });
            CreateMap<CategoryReviewCreateViewModel ,CategoryReview >()
                .ForMember(dest => dest.Body , opts => opts.MapFrom(src => src.Body))
                .ForMember(dest => dest.IsActive , opts => opts.MapFrom(src => src.IsActive))
                .ForAllOtherMembers(opt => opt.Ignore());



            CreateMap<CategoryReview ,CategoryReviewEditViewModel >()
                 .ProjectUsing(src => new CategoryReviewEditViewModel
                 {
                     Body = src.Body,
                     IsActive = src.IsActive
                 });
            CreateMap<CategoryReview, CategoryReviewEditViewModel>()
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
                .ForAllOtherMembers(opt => opt.Ignore());
            


            CreateMap<CategoryReview, CategoryReviewDetailsViewModel >()
                 .ProjectUsing(src => new CategoryReviewDetailsViewModel
                 {
                     Body = src.Body,
                     IsActive = src.IsActive
                 });
            CreateMap<CategoryReview, CategoryReviewDetailsViewModel>()
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForMember(dest => dest.IsActive, opts => opts.MapFrom(src => src.IsActive))
                .ForAllOtherMembers(opt => opt.Ignore());


        }
        public override string ProfileName => GetType().Name;
    }
}
