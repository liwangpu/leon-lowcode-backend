using LCB.API.Application.Queries.Dynamic;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCB.API.Controllers
{
    [Route("api/[controller]/{resource}")]
    [ApiController]
    public class DynamicController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DynamicController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Query")]
        public async Task<IActionResult> QueryAsync([FromRoute] string resource, [FromBody] DynamicQuery query)
        {
            await _mediator.Send(query);
            return Ok(resource);
        }
    }
}
