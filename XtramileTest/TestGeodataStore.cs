using NUnit.Framework;
using XtramileData;

namespace XtramileTest
{
    public class TestGeodataStore
    {
        private GeodataStore geodataStore;

        public TestGeodataStore()
        {
            geodataStore = new GeodataStore("data.json");
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveAllCountries()
        {
            var countries = geodataStore.GetAll();
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
            var countries = geodataStore.GetCountries();
            Assert.AreEqual(3, countries.Count);
            Assert.AreEqual("Indonesia", countries[0]);
            Assert.AreEqual("Singapore", countries[2]);
            //Assert.Pass();
        }

        [Test]
        public void RetrieveCitiesOfIndonesia()
        {
            var cities = geodataStore.GetCitiesByCountry("Indonesia");
            Assert.AreEqual(4, cities.Count);
            Assert.AreEqual("Jakarta", cities[0]);
            Assert.AreEqual("Medan", cities[3]);
            //Assert.Pass();
        }

        [Test]
        public void RetrieveCitiesOfSingapore()
        {
            var cities = geodataStore.GetCitiesByCountry("Singapore");
            Assert.AreEqual(1, cities.Count);
            Assert.AreEqual("Singapore", cities[0]);
            //Assert.Pass();
        }
    }
}