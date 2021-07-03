using System;
using System.Collections.Generic;
using System.Text;

namespace XtramileCore
{
    public interface IGeodataRepository
    {
        List<Geodata> GetAll();
        Geodata GetOneCountry(string country);
        List<string> GetCountries();
        List<string> GetCitiesByCountry(string country);
    }
}
