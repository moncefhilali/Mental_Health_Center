using Microsoft.Extensions.DependencyInjection;

namespace MHC.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionApplication(this IServiceCollection services)
        {
            //// MediatR
            //services.AddMediatR(typeof(GetAllUtilisateurQuery));
            //services.AddMediatR(typeof(CreateUtilisateurCommand));
            //services.AddMediatR(typeof(GetAllRoleQuery));
            //services.AddMediatR(typeof(CreateRoleCommand));
            //services.AddMediatR(typeof(GetAllUtilisateurRoleQuery));
            //services.AddMediatR(typeof(CreateUtilisateurRoleCommand));

            //// Mapper
            //services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}