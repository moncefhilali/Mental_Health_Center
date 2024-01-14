using MHC.Infrastructure.Data;
using MHC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MHC.Infrastructure
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionInfrastructure(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // DbContext
            services.AddScoped<DBC>();

            return services;
        }
    }
}