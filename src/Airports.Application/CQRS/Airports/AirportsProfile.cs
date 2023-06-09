using Airports.Application.CQRS.Airports.Queries;
using Airports.Application.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Infrastructure.CQRS.Airports
{
    public class AirportsProfile : Profile
    {
        public AirportsProfile()
        {
            CreateMap<GetDistanceByIATACodesQuery, AirportIATAsDto>();
            

        }
    }
}
