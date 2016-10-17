using AutoMapper;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies ;
namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyQuestionProfile : Profile
    {
        public CompanyQuestionProfile()
        {

            CreateMap<CompanyQuestion, CompanyQuestionCreateViewModel>()
                .ProjectUsing(src => new CompanyQuestionCreateViewModel
                {
                    Body  = src.Body,
                    IsApproved  = src.IsApproved,
                    Title =src.Title 
                });
            CreateMap<CompanyQuestionCreateViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved , opts => opts.MapFrom(src => src.IsApproved ))
               .ForMember(dest => dest.Title , opts => opts.MapFrom(src => src.Title ))
               .ForMember(dest => dest.Body , opts => opts.MapFrom(src => src.Body ))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQuestionEditViewModel>()
                .ProjectUsing(src => new CompanyQuestionEditViewModel
                {
                    Body = src.Body,
                    IsApproved = src.IsApproved,
                    Title = src.Title,
                    Id = src.Id
                });
            CreateMap<CompanyQuestionEditViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQuestionDetailViewModel>()
               .ProjectUsing(src => new CompanyQuestionDetailViewModel
               {
                   Body = src.Body,
                   IsApproved = src.IsApproved,
                   Title = src.Title,
                   Id = src.Id
               });
            CreateMap<CompanyQuestionDetailViewModel, CompanyQuestion>()
              .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQuestionDeleteViewModel>()
              .ProjectUsing(src => new CompanyQuestionDeleteViewModel
              {
                  Body = src.Body,
                  IsApproved = src.IsApproved,
                  Title = src.Title,
                  Id = src.Id
              });
            CreateMap<CompanyQuestionDeleteViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());




        }
    }
}

