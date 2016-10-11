using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanySocial;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Companies
{
    class CompanySocialProfile : Profile
    {
        public CompanySocialProfile()
        {

            CreateMap<CompanySocial, CompanySocialCreateViewModel>()
                .ProjectUsing(src => new CompanySocialCreateViewModel
                {
                    TwitterLink = src.TwitterLink,
                    GooglePlusLink = src.GooglePlusLink,
                    FacebookLink = src.FacebookLink,
                    YoutubeLink = src.YoutubeLink

                });
            CreateMap<CompanySocialCreateViewModel, CompanySocial>()
                .ForMember(dest => dest.TwitterLink, opts => opts.MapFrom(src => src.TwitterLink))
                .ForMember(dest => dest.GooglePlusLink, opts => opts.MapFrom(src => src.GooglePlusLink))
                .ForMember(dest => dest.FacebookLink, opts => opts.MapFrom(src => src.FacebookLink))
                .ForMember(dest => dest.YoutubeLink, opts => opts.MapFrom(src => src.YoutubeLink))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanySocial, CompanySocialDeleteViewModel>()
                .ProjectUsing(src => new CompanySocialDeleteViewModel
                {
                    TwitterLink = src.TwitterLink,
                    GooglePlusLink = src.GooglePlusLink,
                    FacebookLink = src.FacebookLink,
                    YoutubeLink = src.YoutubeLink,
                    Id = src.Id


                });
            CreateMap<CompanySocialDeleteViewModel, CompanySocial>()
                .ForMember(dest => dest.TwitterLink, opts => opts.MapFrom(src => src.TwitterLink))
                .ForMember(dest => dest.GooglePlusLink, opts => opts.MapFrom(src => src.GooglePlusLink))
                .ForMember(dest => dest.FacebookLink, opts => opts.MapFrom(src => src.FacebookLink))
                .ForMember(dest => dest.YoutubeLink, opts => opts.MapFrom(src => src.YoutubeLink))
                .ForAllOtherMembers(opt => opt.Ignore());



            CreateMap<CompanySocial, CompanySocialDetailViewModel>()
                .ProjectUsing(src => new CompanySocialDetailViewModel
                {
                    TwitterLink = src.TwitterLink,
                    GooglePlusLink = src.GooglePlusLink,
                    FacebookLink = src.FacebookLink,
                    YoutubeLink = src.YoutubeLink,
                    Id = src.Id

                });
            CreateMap<CompanySocialDetailViewModel, CompanySocial>()
                .ForMember(dest => dest.TwitterLink, opts => opts.MapFrom(src => src.TwitterLink))
                .ForMember(dest => dest.GooglePlusLink, opts => opts.MapFrom(src => src.GooglePlusLink))
                .ForMember(dest => dest.FacebookLink, opts => opts.MapFrom(src => src.FacebookLink))
                .ForMember(dest => dest.YoutubeLink, opts => opts.MapFrom(src => src.YoutubeLink))
                .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanySocial, CompanySocialEditViewModel>()
                .ProjectUsing(src => new CompanySocialEditViewModel
                {
                    TwitterLink = src.TwitterLink,
                    GooglePlusLink = src.GooglePlusLink,
                    FacebookLink = src.FacebookLink,
                    YoutubeLink = src.YoutubeLink,
                    Id = src.Id

                });
            CreateMap<CompanySocialEditViewModel, CompanySocial>()
                .ForMember(dest => dest.TwitterLink, opts => opts.MapFrom(src => src.TwitterLink))
                .ForMember(dest => dest.GooglePlusLink, opts => opts.MapFrom(src => src.GooglePlusLink))
                .ForMember(dest => dest.FacebookLink, opts => opts.MapFrom(src => src.FacebookLink))
                .ForMember(dest => dest.YoutubeLink, opts => opts.MapFrom(src => src.YoutubeLink))
                .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanySocial, CompanySocialListViewModel>()
                .ProjectUsing(src => new CompanySocialListViewModel
                {
                    TwitterLink = src.TwitterLink,
                    GooglePlusLink = src.GooglePlusLink,
                    FacebookLink = src.FacebookLink,
                    YoutubeLink = src.YoutubeLink,
                    Id = src.Id

                });
            CreateMap<CompanySocialListViewModel, CompanySocial>()
                .ForMember(dest => dest.TwitterLink, opts => opts.MapFrom(src => src.TwitterLink))
                .ForMember(dest => dest.GooglePlusLink, opts => opts.MapFrom(src => src.GooglePlusLink))
                .ForMember(dest => dest.FacebookLink, opts => opts.MapFrom(src => src.FacebookLink))
                .ForMember(dest => dest.YoutubeLink, opts => opts.MapFrom(src => src.YoutubeLink))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
