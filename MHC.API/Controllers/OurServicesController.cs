using MediatR;
using MHC.Application.OurServices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var result = await _mediator.Send(new GetAllOurServicesQuery());
            return Ok(result);
        }
    }
}
