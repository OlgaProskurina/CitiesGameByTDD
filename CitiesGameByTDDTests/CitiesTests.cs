using CitiesGameByTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class CitiesTests
    {
        private Cities _cities;


        [TestInitialize]
        public void Init()
        {
            _cities = new Cities();
        }

        [TestMethod()]
        public void LoadCitiesTest()
        {
            Assert.IsTrue(_cities.LoadCities());
        }

        [TestMethod()]
        public void FillLetterCountersKeysTest()
        {
            _cities.FillLetterCountersKeys();
            Assert.IsNotNull(_cities.LetterCounters);
        }

        [TestMethod()]
        public void FillLetterCountersValuesTest()
        {
            _cities.FillLetterCountersKeys();            
            Assert.IsNotNull(_cities.FillLetterCountersValues());
        }

        [TestMethod()]
        public void CheckCityNotFoundTest()
        {
            _cities.LoadCities();
            Assert.AreEqual(CheckCityResult.NotFound, 
                _cities.CheckCity("\0такого города нет"));
        }

        [TestMethod()]
        public void CheckCityWrongFirstLetterTest() 
        {
            _cities.LoadCities();
            Assert.AreEqual(CheckCityResult.WrongFirstLetter,
                _cities.CheckCity("такого города нет"));
        }

        [TestMethod()]
        public void SetCurrentLetterTest()
        {
            _cities.LoadCities();
            _cities.FillLetterCountersKeys();
            _cities.FillLetterCountersValues();

            _cities.SetCurrentLetter("астана");
            
            Assert.AreEqual('а', _cities.CurrentLetter);
        }

        [TestMethod()]
        public void SetCurrentLetterTest2()
        {
            _cities.LoadCities();
            _cities.FillLetterCountersKeys();
            _cities.FillLetterCountersValues();

            _cities.SetCurrentLetter("ярославль");

            Assert.AreEqual('л', _cities.CurrentLetter);
        }



    }
}