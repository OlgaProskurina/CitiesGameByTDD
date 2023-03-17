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

        [TestMethod()]
        public void NextPlayerTest()
        {
            _players.SetPlayers(4);
            Assert.AreEqual(2, _players.NextPlayer());
        }

        [TestMethod()]
        public void ExpelCurrentPlayerTest()
        {
            _players.SetPlayers(5);
            _players.ExpelCurrentPlayer();
            Assert.AreEqual(4, _players.PlayersList.Count);
        }
    }
}