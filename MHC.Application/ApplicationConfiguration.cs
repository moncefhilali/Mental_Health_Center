using MediatR;
using MHC.Application.Clinics.Queries;
using MHC.Application.Mapper;
using MHC.Application.Services.Queries;
using MHC.Application.Treatments.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace MHC.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApplication(this IServiceCollection services)
        {
            // MediatR
            services.AddMediatR(typeof(GetAllClinicsQuery));
            services.AddMediatR(typeof(GetAllServicesQuery));
            services.AddMediatR(typeof(GetAllTreatmentsQuery));

            // Mapper
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}