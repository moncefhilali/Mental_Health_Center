using MediatR;
using MHC.Application.Categories.Queries;
using MHC.Application.Clinics.Queries;
using MHC.Application.ClinicTypes.Queries;
using MHC.Application.Doctors.Queries;
using MHC.Application.Images.Queries;
using MHC.Application.Mapper;
using MHC.Application.OurServices.Queries;
using MHC.Application.Treatments.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace MHC.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApplication(this IServiceCollection services)
        {
            // MediatR
            services.AddMediatR(typeof(GetAllOurServicesQuery));
            services.AddMediatR(typeof(GetAllClinicTypesQuery));
            services.AddMediatR(typeof(GetAllTreatmentsQuery));
            services.AddMediatR(typeof(GetAllCategoriesQuery));
            services.AddMediatR(typeof(GetAllClinicsQuery));
            services.AddMediatR(typeof(GetAllDoctorsQuery));
            services.AddMediatR(typeof(GetAllImagesQuery));

            // Mapper
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}