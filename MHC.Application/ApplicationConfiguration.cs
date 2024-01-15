using MHC.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace MHC.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApplication(this IServiceCollection services)
        {
            // MediatR

            // Mapper
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}