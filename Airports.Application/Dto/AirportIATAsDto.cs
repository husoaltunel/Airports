using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Application.Dto
{
    public class AirportIATAsDto
    {
        public AirportIATAsDto(string firstIATACode, string secondIATACode)
        {
            FirstIATACode = firstIATACode;
            SecondIATACode = secondIATACode;
        }

        public string FirstIATACode { get; set; }
        public string SecondIATACode { get; set; }
    }
}
