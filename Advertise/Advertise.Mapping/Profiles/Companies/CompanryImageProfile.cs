using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyImage1 ;
using AutoMapper;

namespace Advertise.Mapping.Profiles.Companies
{
    class CompanryImageProfile : Profile
    {
        public CompanryImageProfile()
        {

            CreateMap<CompanyImage, CompanyImageCreateViewModel>()
                .ProjectUsing(src => new CompanyImageCreateViewModel
                {
                    FileName = src.FileName,
                    FileSize=src.FileSize ,
                    FileDimension = src.FileDimension ,
                    Order =src.Order 

                });
            CreateMap<CompanyImageCreateViewModel, CompanyImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyImage, CompanyImageEditViewModel >()
                .ProjectUsing(src => new CompanyImageEditViewModel
                {
                    FileName = src.FileName,
                    FileSize = src.FileSize,
                    FileDimension = src.FileDimension,
                    Order = src.Order,
                    Id = src.Id
                });
            CreateMap<CompanyImageEditViewModel, CompanyImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyImage, CompanyImageListViewModel >()
              .ProjectUsing(src => new CompanyImageListViewModel
              {
                  FileName = src.FileName,
                  FileSize = src.FileSize,
                  FileDimension = src.FileDimension,
                  Order = src.Order,
                  Id = src.Id
              });
            CreateMap<CompanyImageListViewModel, CompanyImage >()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<CompanyImage, CompanyImageDetailsViewModel>()
              .ProjectUsing(src => new CompanyImageDetailsViewModel
              {
                  FileName = src.FileName,
                  FileSize = src.FileSize,
                  FileDimension = src.FileDimension,
                  Order = src.Order

              });
            CreateMap<CompanyImageDetailsViewModel, CompanyImage>()
               .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
               .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
               .ForMember(dest => dest.FileDimension, opts => opts.MapFrom(src => src.FileDimension))
               .ForMember(dest => dest.Order, opts => opts.MapFrom(src => src.Order))
               .ForAllOtherMembers(opt => opt.Ignore());


        }
    }
}


