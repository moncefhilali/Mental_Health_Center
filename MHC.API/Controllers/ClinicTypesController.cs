using MediatR;
using MHC.Application.ClinicTypes.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicTypesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClinicTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllClinicTypes()
        {
            var result = await _mediator.Send(new GetAllClinicTypesQuery());
            return Ok(result);
        }
    }
}
