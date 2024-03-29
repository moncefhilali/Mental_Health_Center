﻿using MediatR;
using MHC.Application.Treatments.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class TreatmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TreatmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTreatments()
        {
            var result = await _mediator.Send(new GetAllTreatmentsQuery());
            return Ok(result);
        }
    }
}
