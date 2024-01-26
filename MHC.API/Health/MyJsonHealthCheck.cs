using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MHC.API.Health
{
    public class MyJsonHealthCheck : IHealthCheck
    {
        private readonly HttpClient _httpClient;
        public MyJsonHealthCheck(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                await _httpClient.GetAsync("https://my-json-server.typicode.com/moncefhilali/MyAPI/help");
                return HealthCheckResult.Healthy("Successfully connected to the MyJSON API");
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("Failed to connect to the MyJSON API.", ex);
            }
        }
    }
}
