namespace CitiesGameByTDD
{
    public class Cities
    {
        private List<City> _cities = new List<City>();
        private Dictionary<char, int> _letterCounters = new Dictionary<char, int>();
        public IReadOnlyDictionary<char, int> LetterCounters => _letterCounters;

        // Заполняет словарь алфавитом
        public void FillLetterCountersKeys()
        {
            _letterCounters.Clear();
            for (char i = 'а'; i < 'я' + 1; i++)
            {
                _letterCounters.Add(i,0);
            }
        }

        // TODO: реализовать заполнение значений словаря
        public bool FillLetterCountersValues()
        {
           if (_letterCounters.Count == 0)
                return false;
           return true;
        }

        //TODO: дореализовать повторную загрузку городов
        public bool LoadCities()
        {
            if(_cities.Count == 0)
            {
               _cities = CitiesGameSQLiteLoader.GetCitiesFormBD();
               if(_cities.Count == 0 ) 
               {
                    return false;
               }               
            }             
            return true;
        }
    }
}
