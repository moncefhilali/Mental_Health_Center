using AutoMapper;
using MHC.Application.Categories.ViewModel;
using MHC.Application.Clinics.ViewModel;
using MHC.Application.ClinicTypes.ViewModel;
using MHC.Application.Doctors.ViewModel;
using MHC.Application.Images.ViewModel;
using MHC.Application.OurServices.ViewModel;
using MHC.Application.Treatments.ViewModel;
using MHC.Domain.Entities;

namespace MHC.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<OurService, OurServiceViewModel>().ReverseMap();
            CreateMap<ClinicType, ClinicTypeViewModel>().ReverseMap();
            CreateMap<Treatment, TreatmentViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Clinic, ClinicViewModel>().ReverseMap();
            CreateMap<Doctor, DoctorViewModel>().ReverseMap();
            CreateMap<Image, ImageViewModel>().ReverseMap();
            
            CreateMap<OurService, OurServiceIncludeViewModel>().ReverseMap();
            CreateMap<Treatment, TreatmentIncludeViewModel>().ReverseMap();
            CreateMap<Clinic, ClinicIncludeViewModel>().ReverseMap();
        }
    }
}
