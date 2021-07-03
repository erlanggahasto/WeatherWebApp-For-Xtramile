using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtramileCore;
using XtramileData;

namespace XtramileTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeodataController : ControllerBase
    {
        private GeodataStore _geodataStore;

        public GeodataController()
        {
            _geodataStore = new GeodataStore("data.json");
        }

        //public GeodataController(string geodataConnectionString)
        //{
        //    _geodataStore = new GeodataStore(geodataConnectionString);
        //}

        [HttpGet]
        public string Get()
        {
            return "It's working!";
        }

        [HttpGet]
        [Route("countries")]
        public List<Geodata> Countries()
        {
            return _geodataStore.GetAll();
        }

        [HttpGet]
        [Route("countries/names")]
        public List<string> CountryNames()
        {
            return _geodataStore.GetCountries();
        }

        [HttpGet]
        [Route("cities/{country}")]
        public List<string> Cities(string country)
        {
            return _geodataStore.GetCitiesByCountry(country);
        }
    }
}
