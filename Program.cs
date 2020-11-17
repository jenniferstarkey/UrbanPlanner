using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            {
                FiveOneTwoEigth.Width = 100;
                FiveOneTwoEigth.Depth = 300;
                FiveOneTwoEigth.Stories = 3;
                FiveOneTwoEigth.Construct();
                FiveOneTwoEigth.Purchase("Jack Black");
            }
            Console.WriteLine($@"
            {FiveOneTwoEigth.AllBuildingInfo()}
            Property Size: {FiveOneTwoEigth.Volume} 
            ");
        }
    }
}
