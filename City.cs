using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
        private string _cityName;
        private string _cityMayor;
        private int _established;
        public List<Building> CityBuildings;
        public City(string name, string mayor, int est, List<Building> buildings)
        {
            _cityName = name;
            _cityMayor = mayor;
            _established = est;
            CityBuildings = buildings;
        }

    }
}