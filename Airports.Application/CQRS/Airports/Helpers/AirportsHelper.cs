using Airports.Application.Dto;
using Airports.Application.Result;
using Airports.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Text.Json;

namespace Airports.Application.CQRS.Airports.Helpers
{
    public static class AirportsHelper
    {

        public static IConfiguration config;
        public static void Initialize(IConfiguration Configuration)
        {
            config = Configuration;
        }

        public static Result<List<AirportDto>> GetAirports(AirportIATAsDto airportIATAs)
        {
            if (string.IsNullOrEmpty(airportIATAs.FirstIATACode) || string.IsNullOrEmpty(airportIATAs.SecondIATACode))
            {
                return new Result<List<AirportDto>>("Error");
            }

            var iatas = new List<string>() { airportIATAs.FirstIATACode, airportIATAs.SecondIATACode };
            var airports = new List<AirportDto>();

            foreach (var code in iatas)
            {
                var url = $"{config.GetSection("CTeleportUrl").Value}{code}";

                var webRequest = WebRequest.Create(url);
                webRequest.Method = "GET";

                try
                {
                    using var webResponse = webRequest.GetResponse();
                    using var webStream = webResponse.GetResponseStream();

                    using var reader = new StreamReader(webStream);
                    var data = reader.ReadToEnd();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var airport = JsonSerializer.Deserialize<AirportDto>(data, options);

                    if (airport != null)
                        airports.Add(airport);
                }
                catch (Exception)
                {
                    return new Result<List<AirportDto>>("Error");
                }

            }

            if (airports.Count != 2)
                return new Result<List<AirportDto>>("Error");

            return new Result<List<AirportDto>>(airports);
        }
    }
}
