using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CitiesGameSQLiteLoaderTests
    {
        [TestMethod()]
        public void GetCitiesFormBDTest()
        {
            var loader = new CitiesGameSQLiteLoader();            
            Assert.AreNotEqual(0, loader.GetCitiesFormBD().Count);
        }
    }
}