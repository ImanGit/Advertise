using System;
using Advertise.DomainClasses.Entities.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Advertise.ViewModel.Models.Companies.CompanyAttachment;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.Mapping.Profiles.Companies
{
   public  class CompanyAttachmentProfile:Profile 
    {
       public CompanyAttachmentProfile()
       {
            CreateMap<CompanyAttachment, CompanyAttachmentCreateViewModel >()
               .ProjectUsing(src => new CompanyAttachmentCreateViewModel
               {
                   IsApproved=src.IsApproved ,
                   FileExtension=src.FileExtension ,
                   FileName =src.FileName ,
                   FileSize =src.FileSize ,
                   DownloadCount =src.DownloadCount,
                   Description =src.Description ,
                   Title=src.Title ,
                   Type =src.Type ,
                   
                   }
               );

            CreateMap<CompanyAttachmentCreateViewModel, CompanyAttachment>()
                 .ForMember(dest => dest.IsApproved , opts => opts.MapFrom(src => src.IsApproved))
                 .ForMember(dest => dest.FileExtension, opts => opts.MapFrom(src => src.FileExtension))
                 .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
                 .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
                 .ForMember(dest => dest.DownloadCount, opts => opts.MapFrom(src => src.DownloadCount))
                 .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                 .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                 .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
                 .ForAllOtherMembers(opt => opt.Ignore());


            CreateMap<CompanyAttachment, CompanyAttachmentEditViewModel>()
              .ProjectUsing(src => new CompanyAttachmentEditViewModel
              {
                  IsApproved = src.IsApproved,
                  FileExtension = src.FileExtension,
                  FileName = src.FileName,
                  FileSize = src.FileSize,
                  DownloadCount = src.DownloadCount,
                  Description = src.Description,
                  Title = src.Title,
                  Type = src.Type,

              });

            CreateMap<CompanyAttachmentEditViewModel, CompanyAttachment>()
                 .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
                 .ForMember(dest => dest.FileExtension, opts => opts.MapFrom(src => src.FileExtension))
                 .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
                 .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
                 .ForMember(dest => dest.DownloadCount, opts => opts.MapFrom(src => src.DownloadCount))
                 .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                 .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                 .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
                 .ForAllOtherMembers(opt => opt.Ignore());



            CreateMap<CompanyAttachment, CompanyAttachmentDeleteViewModel>()
            .ProjectUsing(src => new CompanyAttachmentDeleteViewModel
            {
                IsApproved = src.IsApproved,
                FileExtension = src.FileExtension,
                FileName = src.FileName,
                FileSize = src.FileSize,
                DownloadCount = src.DownloadCount,
                Description = src.Description,
                Title = src.Title,
                  //                  Type = src.Type,

              }
            );

            CreateMap<CompanyAttachmentDeleteViewModel, CompanyAttachment>()
                 .ForMember(dest => dest.IsApproved, opts => opts.MapFrom(src => src.IsApproved))
                 .ForMember(dest => dest.FileExtension, opts => opts.MapFrom(src => src.FileExtension))
                 .ForMember(dest => dest.FileName, opts => opts.MapFrom(src => src.FileName))
                 .ForMember(dest => dest.FileSize, opts => opts.MapFrom(src => src.FileSize))
                 .ForMember(dest => dest.DownloadCount, opts => opts.MapFrom(src => src.DownloadCount))
                 .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                 .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                 //               .ForMember(dest => dest.Type, opts => opts.MapFrom(src => src.Type))
                 .ForAllOtherMembers(opt => opt.Ignore());

        
        }
    }
}
