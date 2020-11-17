using System;
using System.Collections.Generic;


namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Building FiveOneTwoEigth = new Building("512 8th Avenue", 1, 2, 3);
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Jack Black");

            //Add to the list

            Building SixFiveEightThird = new Building("658 South 3rd Street", 3, 2, 3);
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Meg Jackson");

            //Add to the list
            List<Building> buildings = new List<Building>();
            buildings.Add(FiveOneTwoEigth);
            buildings.Add(SixFiveEightThird);


            City Cashville = new City("Cashville", "Sir Mayor", 1498, buildings);
            foreach (Building building in Cashville.CityBuildings)
            {
                Console.WriteLine($@"
                {building.AllBuildingInfo()}
                {building.Volume} building size
                ");
            }

        }

    }

}
