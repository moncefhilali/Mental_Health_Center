using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flurl;
using Flurl.Http;

namespace MHC.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class MyJsonController : ControllerBase
    {
        public MyJsonController()
        {
        }

        [HttpGet("Flurl")]
        public async Task<IActionResult> GetFlurl()
        {
            var url = "https://my-json-server.typicode.com/moncefhilali/MyAPI";
            var result = await url.AppendPathSegment("db").GetJsonAsync<object?>();
            return Ok(result);
        }
    }
}
