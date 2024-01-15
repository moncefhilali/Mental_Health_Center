using MediatR;
using MHC.Application.Clinics.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var result = await _mediator.Send(new GetAllClinicsQuery());
            return Ok(result);
        }
    }
}
