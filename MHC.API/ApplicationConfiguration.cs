using MHC.API.Health;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.RateLimiting;
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

            // Rate Limiter
            services.AddRateLimiter(options =>
            {
                options.AddFixedWindowLimiter("FixedWindowPolicy", opt =>
                {
                    opt.Window = TimeSpan.FromSeconds(10);
                    opt.PermitLimit = 1;
                    opt.QueueLimit = 1;
                    opt.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
                }).RejectionStatusCode = 429;
            });

            // Health Check
            services.AddHealthChecks()
                .AddCheck<DatabaseHealthCheck>("Database")
                .AddCheck<MyJsonHealthCheck>("MyJSON API");

            // Polly
            var retryPolicy = Policy
                   .Handle<Exception>()
                   .RetryAsync(5);
            services.AddSingleton(retryPolicy);

            // HttpClient
            services.AddHttpClient();

            // Cors
            services.AddCors();

            return services;
        }
    }
}
