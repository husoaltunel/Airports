using Airports.Application.Result;
using Airports.Infrastructure.CQRS.AirportDistances.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airports.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AirportsController(IMediator mediator) => _mediator = mediator;

        [HttpGet("getDistanceByIATACodes/{firstIATACode}/{secondIATACode}")]
        public async Task<Result<double>> GetDistanceByIATACodes(string firstIATACode, string secondIATACode)
        {
            return await _mediator.Send(new GetDistanceByIATACodesQuery(firstIATACode,secondIATACode));
        }


    }

    
}
