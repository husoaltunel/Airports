using Airports.Application.Dto;
using Airports.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Application.Helpers
{
    public static class DistanceHelper
    {
        public static double GetDistance(LocationsDto locations)
        {

            if ((locations.FirstLocation.Lat == locations.SecondLocation.Lat) && (locations.FirstLocation.Lon == locations.SecondLocation.Lon))
            {
                return 0;
            }
            else
            {
                double theta = locations.FirstLocation.Lon - locations.SecondLocation.Lon;
                double dist = Math.Sin(Deg2rad(locations.FirstLocation.Lat)) * Math.Sin(Deg2rad(locations.SecondLocation.Lat)) + Math.Cos(Deg2rad(locations.FirstLocation.Lat)) * Math.Cos(Deg2rad(locations.SecondLocation.Lat)) * Math.Cos(Deg2rad(theta));
                dist = Math.Acos(dist);
                dist = Rad2deg(dist);
                dist = dist * 60 * 1.1515;
                if (locations.Unit == 'K')
                {
                    dist = dist * 1.609344;
                }
                else if (locations.Unit == 'N')
                {
                    dist = dist * 0.8684;
                }
                return (dist);
            }



        }

        private static double Deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private static double Rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }


    }



}
