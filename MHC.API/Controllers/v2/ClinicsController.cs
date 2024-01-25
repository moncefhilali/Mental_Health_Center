using MediatR;
using MHC.Application.Clinics.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers.v2
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class ClinicsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClinicsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllClinics()
        {
            var result = await _mediator.Send(new GetAllIncludeClinicsQuery());
            return Ok(result);
        }
    }
}
