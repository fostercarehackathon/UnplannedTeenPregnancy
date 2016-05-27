using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace FosterConnect.Models.Resources
{
    public class Location
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }

        public string phone { get; set; }
    }

    public class IndexModel
    {
        public static List<Location> GetLocations()
        {

            var path = HttpContext.Current.Server.MapPath("~/App_Data/addresses.json");
            var data = File.ReadAllText(path);

            var locations = Json.Decode<List<Location>>(data);
            var cnt = 0;

            foreach (var location in locations)
            {

                location.Id = ++cnt;
            }

            return locations;

        }


    }

}