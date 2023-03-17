namespace CitiesGameByTDD
{
    public class Cities
    {
        private List<City> _cities;

        //TODO: дореализовать загрузку списка
        public bool LoadCities()
        {
            _cities = new List<City>();
            if (_cities.Count == 0)
                return false;
            return true;
        }
    }
}
