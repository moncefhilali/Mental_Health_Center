using AutoMapper;
using MHC.Application.Clinics.ViewModel;
using MHC.Application.OurServices.ViewModel;
using MHC.Application.Treatments.ViewModel;
using MHC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Treatment, TreatmentViewModel>().ReverseMap();
            CreateMap<OurService, OurServiceViewModel>().ReverseMap();
            CreateMap<Clinic, ClinicViewModel>().ReverseMap();
        }
    }
}
