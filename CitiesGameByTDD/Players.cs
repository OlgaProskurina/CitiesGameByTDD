namespace CitiesGameByTDD
{
    public class Players
    {
        private List<int> _playersList = new List<int>();
        public IReadOnlyList<int> PlayersList => _playersList;
        private int _currentPalyerIndex = 0;
        public int CurrentPlayer { get; private set; } 

        public void SetPlayers(int playersCount)
        {
            _playersList.Clear();
            _currentPalyerIndex = 0;
            for (int i = 1; i < playersCount + 1; i++)
            {
                _playersList.Add(i);
            }
            CurrentPlayer = _playersList[0];
        }

        // Возврат: номер следующего игрока
        public int NextPlayer()
        {
            if (_currentPalyerIndex < _playersList.Count -1)
            {
                _currentPalyerIndex++;
            }
            else
            {
                _currentPalyerIndex = 0;
            }
            return _playersList[_currentPalyerIndex];
        }


        public void ExpelCurrentPlayer()
        {
            _playersList.RemoveAt(_currentPalyerIndex);
        }
    }
}
