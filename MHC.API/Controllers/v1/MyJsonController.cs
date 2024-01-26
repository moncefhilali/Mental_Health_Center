using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polly.Retry;
using Flurl;
using Flurl.Http;

namespace MHC.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class MyJsonController : ControllerBase
    {
        private readonly AsyncRetryPolicy _retryPolicy;
        public MyJsonController(AsyncRetryPolicy retryPolicy)
        {
            _retryPolicy = retryPolicy;
        }

        [HttpGet("Flurl")]
        public async Task<IActionResult> GetFlurl()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI";
            var result = await _retryPolicy.ExecuteAsync(async () => await url.AppendPathSegment("help").GetJsonAsync<object?>());
            return Ok(result);
        }
    }
}
