using CitiesGameByTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitiesGameByTDD.Tests
{
    [TestClass()]
    public class PlayersTests
    {
        private Players _players;

        [TestInitialize]
        public void Init() 
        {
            _players = new Players();
        }


        [TestMethod()]
        public void SetPlayersTest()
        {
            _players.SetPlayers(5);
            Assert.AreEqual(5, _players.PlayersList.Count);
        }

        
    }
}