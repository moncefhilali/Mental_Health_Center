using MHC.Infrastructure.Data;
using MHC.Infrastructure.Repositories;
using MHC.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MHC.Infrastructure
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionInfrastructure(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IOurServiceRepository, OurServiceRepository>();
            services.AddScoped<IClinicTypeRepository, ClinicTypeRepository>();
            services.AddScoped<ITreatmentRepository, TreatmentRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IClinicRepository, ClinicReository>();
            services.AddScoped<IImageRepository, ImageRepository>();

            // DbContext
            services.AddScoped<DBC>();

            return services;
        }
    }
}