using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestion ;
using AutoMapper;
namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyQuestionProfile : Profile
    {
        public CompanyQuestionProfile()
        {

            CreateMap<CompanyQuestion, CompanyQCreateViewModel>()
                .ProjectUsing(src => new CompanyQCreateViewModel
                {
                    Body  = src.Body,
                    IsApproved  = src.IsApproved,
                    Title =src.Title 
                });
            CreateMap<CompanyQCreateViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved , opts => opts.MapFrom(src => src.IsApproved ))
               .ForMember(dest => dest.Title , opts => opts.MapFrom(src => src.Title ))
               .ForMember(dest => dest.Body , opts => opts.MapFrom(src => src.Body ))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQEditViewModel>()
                .ProjectUsing(src => new CompanyQEditViewModel
                {
                    Body = src.Body,
                    IsApproved = src.IsApproved,
                    Title = src.Title,
                    Id = src.Id
                });
            CreateMap<CompanyQEditViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQDetailViewModel>()
               .ProjectUsing(src => new CompanyQDetailViewModel
               {
                   Body = src.Body,
                   IsApproved = src.IsApproved,
                   Title = src.Title,
                   Id = src.Id
               });
            CreateMap<CompanyQDetailViewModel, CompanyQuestion>()
              .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyQuestion, CompanyQDeleteViewModel>()
              .ProjectUsing(src => new CompanyQDeleteViewModel
              {
                  Body = src.Body,
                  IsApproved = src.IsApproved,
                  Title = src.Title,
                  Id = src.Id
              });
            CreateMap<CompanyQDeleteViewModel, CompanyQuestion>()
               .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
               .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
               .ForMember(dest => dest.Body, opts => opts.MapFrom(src => src.Body))
               .ForAllOtherMembers(opt => opt.Ignore());




        }
    }
}

