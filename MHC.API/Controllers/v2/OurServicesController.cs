using MediatR;
using MHC.Application.OurServices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers.v2
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class OurServicesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OurServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllServices()
        {
            var result = await _mediator.Send(new GetAllIncludeOurServicesQuery());
            return Ok(result);
        }
    }
}
