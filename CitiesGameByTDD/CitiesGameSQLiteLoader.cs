using System.Data.SQLite;

namespace CitiesGameByTDD
{
    public class CitiesGameSQLiteLoader
    {
        // Возврат: список с городами из tddbd.sqlite
        public static List<City> GetCitiesFormBD()
        {
            var cities = new List<City>();
            using (var connection = new SQLiteConnection(@"Data Source=tddbd.sqlite"))
            {
                connection.Open();
                using (var command = new SQLiteCommand(@"SELECT Name FROM cities", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {                        
                        while (reader.Read())
                        {
                            cities.Add(new City(reader.GetString(0)));
                        }
                        
                    }
                }
                connection.Close();
            }
            return cities;
        }        

    }
}
