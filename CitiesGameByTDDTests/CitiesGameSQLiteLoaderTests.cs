using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CitiesGameSQLiteLoaderTests
    {
        [TestMethod()]
        public void GetCitiesFormBDTest()
        {
            Assert.AreNotEqual(0, CitiesGameSQLiteLoader.GetCitiesFormBD().Count);
        }
    }
}