using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies ;
using Advertise.ViewModel.Models .Companies ;
using AutoMapper ;

namespace Advertise.Mapping.Profiles.Companies
{
    public class CompanryProfile : Profile
    {
        public CompanryProfile()
        {
            CreateMap<Company, CompanyCreateViewModel>()
                .ProjectUsing(src => new CompanyCreateViewModel
                {
                    Code = src.Code,
                    BrandName = src.BrandName,
                    BackgroundFileName = src.BackgroundFileName,
                    Description = src.Description,
                    Email = src.Email,
                    MobileNumber = src.MobileNumber,
                    EmployeeCount = src.EmployeeCount,
                    EstablishedOn = src.EstablishedOn,
                    LogoFileName = src.LogoFileName,
                    PhoneNumber = src.PhoneNumber,
                    WebSite = src.WebSite
                }
                );

            CreateMap<CompanyCreateViewModel, Company>().ProjectUsing(src => new Company
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite
            });


            CreateMap<Company, CompanyListViewModel>().ProjectUsing(src => new CompanyListViewModel
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite,
                Id = src.Id

            });

            CreateMap<CompanyListViewModel ,Company >( ).ProjectUsing( src=> new Company
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite,
                Id = src.Id 


            });


            CreateMap<Company, CompanyEditViewModel>().ProjectUsing(src => new CompanyEditViewModel
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite,
                Id=src.Id 

            });

            CreateMap<CompanyEditViewModel, Company>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description , opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.Email , opts => opts.MapFrom(src => src.Email ))
                .ForMember(dest => dest.EmployeeCount , opts => opts.MapFrom(src => src.EmployeeCount ))
                .ForMember(dest => dest.EstablishedOn , opts => opts.MapFrom(src => src.EstablishedOn ))
                .ForMember(dest => dest.LogoFileName , opts => opts.MapFrom(src => src.LogoFileName ))
                .ForMember(dest => dest.MobileNumber , opts => opts.MapFrom(src => src.MobileNumber ))
                .ForMember(dest => dest.PhoneNumber , opts => opts.MapFrom(src => src.PhoneNumber ))
                .ForMember(dest => dest.WebSite , opts => opts.MapFrom(src => src.WebSite ))
                .ForMember(dest => dest.BackgroundFileName , opts => opts.MapFrom(src => src.BackgroundFileName ))
                .ForMember(dest => dest.BrandName , opts => opts.MapFrom(src => src.BrandName ))
                .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<Company, CompanyDeleteViewModel>().ProjectUsing(src => new CompanyDeleteViewModel
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite,
                Id=src.Id 


            });

            CreateMap<CompanyDeleteViewModel, Company>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                .ForMember(dest => dest.EmployeeCount, opts => opts.MapFrom(src => src.EmployeeCount))
                .ForMember(dest => dest.EstablishedOn, opts => opts.MapFrom(src => src.EstablishedOn))
                .ForMember(dest => dest.LogoFileName, opts => opts.MapFrom(src => src.LogoFileName))
                .ForMember(dest => dest.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                .ForMember(dest => dest.PhoneNumber, opts => opts.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.WebSite, opts => opts.MapFrom(src => src.WebSite))
                .ForMember(dest => dest.BackgroundFileName, opts => opts.MapFrom(src => src.BackgroundFileName))
                .ForMember(dest => dest.BrandName, opts => opts.MapFrom(src => src.BrandName))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Company, CompanyDetailsViewModel >().ProjectUsing(src => new CompanyDetailsViewModel
            {
                Code = src.Code,
                BrandName = src.BrandName,
                BackgroundFileName = src.BackgroundFileName,
                Description = src.Description,
                Email = src.Email,
                MobileNumber = src.MobileNumber,
                EmployeeCount = src.EmployeeCount,
                EstablishedOn = src.EstablishedOn,
                LogoFileName = src.LogoFileName,
                PhoneNumber = src.PhoneNumber,
                WebSite = src.WebSite,
                Id=src.Id 


            });

            CreateMap<CompanyDetailsViewModel, Company>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                .ForMember(dest => dest.EmployeeCount, opts => opts.MapFrom(src => src.EmployeeCount))
                .ForMember(dest => dest.EstablishedOn, opts => opts.MapFrom(src => src.EstablishedOn))
                .ForMember(dest => dest.LogoFileName, opts => opts.MapFrom(src => src.LogoFileName))
                .ForMember(dest => dest.MobileNumber, opts => opts.MapFrom(src => src.MobileNumber))
                .ForMember(dest => dest.PhoneNumber, opts => opts.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.WebSite, opts => opts.MapFrom(src => src.WebSite))
                .ForMember(dest => dest.BackgroundFileName, opts => opts.MapFrom(src => src.BackgroundFileName))
                .ForMember(dest => dest.BrandName, opts => opts.MapFrom(src => src.BrandName))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
        public override string ProfileName => GetType().Name;
    }
}