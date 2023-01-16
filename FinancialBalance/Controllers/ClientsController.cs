using FinancialBalance.Domain.Models.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LancamentosFinanceiros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientsController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("cash")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetClientsCash([FromRoute] Guid clientId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("entries")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetClientsEntries([FromQuery] ClientEntriesRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPost("entriesFile")]
        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GenerateClientsPastEntriesFile([FromQuery] ClientPastEntriesRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet("entriesFile")]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        public IActionResult GetClientsPastEntriesFile([FromRoute] Guid clientId, [FromQuery] DateTime? beginningDate, [FromQuery] DateTime? endDate)
        {
            throw new NotImplementedException();
        }
    }
}
