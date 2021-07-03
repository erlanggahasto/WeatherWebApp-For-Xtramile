using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XtramileTask2.Controllers;

namespace XtramileTest
{
    public class TestGeodataWebAPI
    {
        private GeodataController geodataWebAPI;

        public TestGeodataWebAPI()
        {
            geodataWebAPI = new GeodataController();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveAllCountries()
        {
            var countries = geodataWebAPI.Countries();
            Assert.AreEqual(3, countries.Count);
            Assert.AreEqual("Indonesia", countries[0].Country);
            Assert.AreEqual(4, countries[0].Cities.Count);
            Assert.AreEqual("Singapore", countries[2].Country);
            Assert.AreEqual(1, countries[2].Cities.Count);
            //Assert.Pass();
        }

        [Test]
        public void RetrieveAllCountriesNames()
        {
            var countries = geodataWebAPI.CountryNames();
            Assert.AreEqual(3, countries.Count);
            Assert.AreEqual("Indonesia", countries[0]);
            Assert.AreEqual("Singapore", countries[2]);
            //Assert.Pass();
        }

        [Test]
        public void RetrieveCitiesOfIndonesia()
        {
            var cities = geodataWebAPI.Cities("Indonesia");
            Assert.AreEqual(4, cities.Count);
            Assert.AreEqual("Jakarta", cities[0]);
            Assert.AreEqual("Medan", cities[3]);
            //Assert.Pass();
        }

        [Test]
        public void RetrieveCitiesOfSingapore()
        {
            var cities = geodataWebAPI.Cities("Singapore");
            Assert.AreEqual(1, cities.Count);
            Assert.AreEqual("Singapore", cities[0]);
            //Assert.Pass();
        }
    }
}
