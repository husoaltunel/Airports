using Airports.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Application.Dto
{
    public class LocationsDto
    {
        public LocationsDto(LocationDto firstLocation, LocationDto secondLocation,char? unit = null)
        {
            FirstLocation = firstLocation;
            SecondLocation= secondLocation;
            Unit = unit;
        }
        public LocationDto FirstLocation { get; set; }
        public LocationDto SecondLocation { get; set; }
        public char? Unit { get; set; }
    }
}
