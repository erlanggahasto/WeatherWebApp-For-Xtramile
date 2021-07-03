using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XtramileCore;

namespace XtramileData
{
    public class GeodataStore : IGeodataRepository
    {
        List<Geodata> geodata;

        public GeodataStore(string connectionString)
        {
            var myJsonString = File.ReadAllText(connectionString);
            geodata = JsonConvert.DeserializeObject<List<Geodata>>(myJsonString);
        }

        public List<Geodata> GetAll()
        {
            return geodata;
        }

        public Geodata GetOneCountry(string country)
        {
            return geodata.Find(c => c.Country == country);
        }

        public List<string> GetCountries()
        {
            return geodata.Select(c => c.Country).ToList();
        }

        public List<string> GetCitiesByCountry(string country)
        {
            return GetOneCountry(country).Cities;
        }
    }
}
