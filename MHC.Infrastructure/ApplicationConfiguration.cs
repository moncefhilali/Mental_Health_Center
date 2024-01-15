﻿using MHC.Infrastructure.Data;
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
            services.AddScoped<ITreatmentRepository, TreatmentRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IClinicRepository, ClinicReository>();

            // DbContext
            services.AddScoped<DBC>();

            return services;
        }
    }
}