using Airports.Application.Dto;
using Airports.Infrastructure.CQRS.AirportDistances.Queries;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Infrastructure.CQRS.Airports
{
    public static class AirportsMappingExtension
    {
        internal static IMapper Mapper;

        static AirportsMappingExtension()
        {
            Mapper = new MapperConfiguration(cfg => cfg.AddProfile<AirportsProfile>()).CreateMapper();
        }

        public static AirportIATAsDto AsAirportIATAsDto(this GetDistanceByIATACodesQuery query)
        {
            return Mapper.Map<AirportIATAsDto>(query);
        }


    }
}
