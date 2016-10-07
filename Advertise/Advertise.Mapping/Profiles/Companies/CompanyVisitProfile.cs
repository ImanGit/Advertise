using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ViewModel.Models.Companies.CompanyVisit ;
using AutoMapper;


namespace Advertise.Mapping.Profiles.Companies
{
    class CompanyVisitProfile : Profile
    {
        public CompanyVisitProfile()
        {

            CreateMap<CompanyVisit, CompanyVisitCreateViewModel>()
                .ProjectUsing(src => new CompanyVisitCreateViewModel
                {
                    IsVisit = src.IsVisit

                });
            CreateMap<CompanyVisitCreateViewModel, CompanyVisit>()
                .ForMember(dest => dest.IsVisit, opts => opts.MapFrom(src => src.IsVisit))
                .ForAllOtherMembers(opt => opt.Ignore());

        }
    }
}