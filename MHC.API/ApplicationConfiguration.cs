using Microsoft.AspNetCore.Mvc.Versioning;
using Polly;

namespace MHC.API
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddDependecyInjectionAPI(this IServiceCollection services)
        {
            // API Versioning
            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.ReportApiVersions = true;
                options.ApiVersionReader = ApiVersionReader.Combine(new HeaderApiVersionReader("x-version"));
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            // Polly
            var retryPolicy = Policy
                   .Handle<Exception>()
                   .RetryAsync(5);
            services.AddSingleton(retryPolicy);

            // HttpClient
            services.AddHttpClient();

            return services;
        }
    }
}
