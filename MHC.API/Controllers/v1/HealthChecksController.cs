using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace MHC.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [EnableRateLimiting("FixedWindowPolicy")]
    public class HealthChecksController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public HealthChecksController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> CheckHealth()
        {
            var result = await _httpClient.GetFromJsonAsync<object?>("https://localhost:7216/_health");
            return Ok(result);
        }
    }
}
