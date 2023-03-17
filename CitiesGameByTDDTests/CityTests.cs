using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CityTests
    {
        [TestMethod()]
        public void CityTest()
        {
            var cityName = "астана";
            var city = new City(cityName);
            Assert.AreEqual(cityName, city.Name);
        }

        [TestMethod()]
        [DataRow(true)]
        [DataRow(false)]
        public void CityUsedTest(bool isUsed)
        {
            var cityName = "астана";
            var city = new City(cityName);
            city.IsUsed = isUsed;
            Assert.AreEqual(isUsed, city.IsUsed);
        }
    }
}