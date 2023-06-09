using Airports.Application.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Infrastructure.CQRS.AirportDistances.Queries
{
    public class GetDistanceByIATACodesQuery : IRequest<Result<double>>
    {
        public GetDistanceByIATACodesQuery(string firstIATACode, string secondIATACode)
        {
            FirstIATACode = firstIATACode;
            SecondIATACode = secondIATACode;
        }

        public string FirstIATACode { get; set; }
        public string SecondIATACode { get; set; }
    }
}
