using Airports.Application.Result;
using MediatR;

namespace Airports.Application.CQRS.Airports.Queries
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
