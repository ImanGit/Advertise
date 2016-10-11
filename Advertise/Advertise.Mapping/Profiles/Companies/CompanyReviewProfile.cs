using AutoMapper;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyReview;

namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyReviewProfile : Profile
    {
        public CompanyReviewProfile()
        {

            CreateMap<CompanyReview, CompanyReviewCreateViewModel>()
                .ProjectUsing(src => new CompanyReviewCreateViewModel
                {
                    Body = src.Body,
                    Active = src.Active,
                });
            CreateMap<CompanyReviewCreateViewModel, CompanyReview>()
                .ForMember(dest => dest.Active, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReview, CompanyReviewDeleteViewModel >()
               .ProjectUsing(src => new CompanyReviewDeleteViewModel
               {
                   Body = src.Body,
                   Active = src.Active,
                   Id=src.Id 
               });
            CreateMap<CompanyReviewDeleteViewModel, CompanyReview>()
                .ForMember(dest => dest.Active, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReview, CompanyReviewDetailViewModel>()
               .ProjectUsing(src => new CompanyReviewDetailViewModel
               {
                   Body = src.Body,
                   Active = src.Active,
                   Id = src.Id
               });
            CreateMap<CompanyReviewEditViewModel , CompanyReview>()
                .ForMember(dest => dest.Active, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyReview, CompanyReviewListViewModel >()
               .ProjectUsing(src => new CompanyReviewListViewModel
               {
                   Body = src.Body,
                   Active = src.Active,
                   Id = src.Id
               });
            CreateMap<CompanyReviewListViewModel, CompanyReview>()
                .ForMember(dest => dest.Active, opts => opts.MapFrom(src => src.Active))
                .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}