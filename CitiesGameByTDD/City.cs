namespace CitiesGameByTDD
{
    public class City
    {
        public string Name { get; init; }

        public City(string cityName) 
        {
            Name = cityName.Trim().ToLowerInvariant();
        }
    }
}
