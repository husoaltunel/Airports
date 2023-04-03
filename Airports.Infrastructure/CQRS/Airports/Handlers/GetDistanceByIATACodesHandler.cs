using Airports.Application.Dto;
using Airports.Application.Helpers;
using Airports.Application.Result;
using Airports.Domain.Models;
using Airports.Infrastructure.CQRS.AirportDistances.Queries;
using Airports.Infrastructure.CQRS.Airports;
using Airports.Infrastructure.CQRS.Airports.Helpers;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Airports.Infrastructure.CQRS.AirportDistances.Handlers
{
    public class GetDistanceByIATACodesHandler : IRequestHandler<GetDistanceByIATACodesQuery, Result<double>>
    {
        private static IConfiguration _config;
        public GetDistanceByIATACodesHandler(IConfiguration config)
        {
            _config= config;
        }
        public async Task<Result<double>> Handle(GetDistanceByIATACodesQuery request, CancellationToken cancellationToken)
        {

            AirportsHelper.Initialize(_config);
            var airports = AirportsHelper.GetAirports(request.AsAirportIATAsDto());

            if (!airports.Success)
            {
                return new Result<double>("Error");
            }

            var distance = DistanceHelper.GetDistance(new LocationsDto(airports.Entity[0].Location, airports.Entity[1].Location));

            return new Result<double>(distance);





        }
    }
}
