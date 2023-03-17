namespace CitiesGameByTDD
{
    public class Players
    {
        private List<int> _playersList = new List<int>();
        public IReadOnlyList<int> PlayersList => _playersList;
        private int _currentPalyerIndex = 0;

        public void SetPlayers(int playersCount)
        {
            for (int i = 1; i < playersCount + 1; i++)
            {
                _playersList.Add(i);
            }            
        }

        // TODO: дореализовать
        public int NextPlayer()
        {
            return 2;
        }

        public void ExpelCurrentPlayer()
        {
            _playersList.Remove(_currentPalyerIndex);
        }
    }
}
