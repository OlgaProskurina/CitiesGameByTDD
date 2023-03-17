using Accessibility;
using System.DirectoryServices.ActiveDirectory;

namespace CitiesGameByTDD
{
    public class Cities
    {
        private List<City> _cities = new List<City>();

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
