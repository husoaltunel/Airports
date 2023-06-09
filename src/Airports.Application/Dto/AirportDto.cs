using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Airports.Domain.Models
{
    public class AirportDto
    {

        public string Country { get; set; }
        [JsonPropertyName("city_iata")]
        public string CityIata { get; set; }
        public string Iata { get; set; }
        public string City { get; set; }
        public string TimezoneRegionName { get; set; }
        [JsonPropertyName("country_iata")]
        public string CountryIata { get; set; }
        public long Rating { get; set; }
        public string Name { get; set; }
        public LocationDto Location { get; set; }
        public string Type { get; set; }
        public long Hubs { get; set; }
    }
}
