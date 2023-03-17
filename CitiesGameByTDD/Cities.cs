﻿namespace CitiesGameByTDD
{
    public enum CheckCityResult
    {
        NotFound,
        FoundUsed,
        FoundUnused,
        WrongFirstLetter
    }


    public class Cities
    {
        private List<City> _cities = new List<City>();
        private Dictionary<char, int> _letterCounters = new Dictionary<char, int>();
        public IReadOnlyDictionary<char, int> LetterCounters => _letterCounters;
        public char CurrentLetter { get; private set; } = char.MinValue;

        // TODO: дореализовать метод
        public void AcceptCity(string cityName)
        {
            _letterCounters[cityName[0]]--;
        }

        // TODO: дореализовать для FoundUsed
        public CheckCityResult CheckCity(string cityName)
        {
            var cityNameLow = cityName.Trim().ToLowerInvariant();
            if (CurrentLetter != char.MinValue && cityName[0] != CurrentLetter) 
            {
                return CheckCityResult.WrongFirstLetter;
            }
            var city = _cities.Find(city => city.Name == cityNameLow);
            if (city != null)
            {
                if (!city.IsUsed)
                {
                    return CheckCityResult.FoundUnused;
                }                
            }       
            return CheckCityResult.NotFound;
        }

        // Заполняет словарь алфавитом
        public void FillLetterCountersKeys()
        {
            _letterCounters.Clear();
            for (char i = 'а'; i < 'я' + 1; i++)
            {
                _letterCounters.Add(i,0);
            }
        }

        // Возврат: false ключи словаря не заполнены
        public bool FillLetterCountersValues()
        {
            if (_letterCounters.Count == 0)
                return false;        

            foreach (char letter in _letterCounters.Keys)
                _letterCounters[letter] = 0;
            foreach (var city in _cities)
            {
                if (!city.IsUsed)
                {
                    _letterCounters[city.Name[0]]++;
                }
            }
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

        
        public void SetCurrentLetter(string cityName)
        {
            int letterIndex = cityName.Length - 1;
            // если городов на эту букву больше нет
            while (0 == _letterCounters[cityName[letterIndex]])
            {
                letterIndex--;
                if (letterIndex < 0) // на любую букву cityName не осталось городов
                {
                    CurrentLetter = char.MaxValue;
                    return;
                }
            }
            CurrentLetter = cityName[letterIndex];
        }
    }
}
