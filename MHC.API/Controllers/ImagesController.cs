using MediatR;
using MHC.Application.Images.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllImages()
        {
            var result = await _mediator.Send(new GetAllImagesQuery());
            return Ok(result);
        }
    }
}
