namespace CitiesGameByTDD
{
    public class City
    {
        public string Name { get; init; }
        public bool IsUsed { get; set; } = false;

        public City(string cityName) 
        {
            Name = cityName.Trim().ToLowerInvariant();
        }
    }
}
