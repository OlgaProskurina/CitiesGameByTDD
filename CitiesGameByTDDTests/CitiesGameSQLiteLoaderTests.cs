using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CitiesGameSQLiteLoaderTests
    {
        [TestMethod()]
        public void GetCitiesFormBDEmptyListTest()
        {
            var loader = new CitiesGameSQLiteLoader();            
            Assert.AreEqual(0, loader.GetCitiesFormBD().Count);
        }
    }
}