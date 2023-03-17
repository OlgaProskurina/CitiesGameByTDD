using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CitiesTests
    {
        [TestMethod()]
        public void LoadCitiesTest()
        {
            var cities = new Cities();           
            Assert.IsTrue(cities.LoadCities());
        }
    }
}