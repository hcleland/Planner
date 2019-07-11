using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Building FiveOneTwoEigth = new Building("512 8th Avenue", "Joe Smith")
            {
                Width = 500,
                Height = 800,
                Stories = 2
            };

            Building RedBuilding = new Building("645 Elm Street", "Jane Smith")
            {
                Width = 600,
                Height = 900,
                Stories = 3
            };

            Building OrangeBuilding = new Building("12 Local Avenue", "Billy Jones")
            {
                Width = 700,
                Height = 1000,
                Stories = 2
            };

            Building YellowBuilding = new Building("9009 Party Court", "Betty Jones")
            {
                Width = 800,
                Height = 1100,
                Stories = 4
            };

            Building GreenBuilding = new Building("8788 Huntington Parkway", "Andrew Wright")
            {
                Width = 900,
                Height = 1200,
                Stories = 2
            };


            FiveOneTwoEigth.Construct();
            RedBuilding.Construct();
            OrangeBuilding.Construct();
            YellowBuilding.Construct();
            GreenBuilding.Construct();

            FiveOneTwoEigth.Purchase("Shelley Arnold");
            RedBuilding.Purchase("Emily Loggins");
            OrangeBuilding.Purchase("Addam Joor");
            YellowBuilding.Purchase("Eliot Clarke");
            GreenBuilding.Purchase("Heather Cleland");

            City city1 = new City("Nashville");

            List<Building> listOfBuildings = new List<Building>();

            listOfBuildings.Add(FiveOneTwoEigth);
            listOfBuildings.Add(RedBuilding);
            listOfBuildings.Add(OrangeBuilding);
            listOfBuildings.Add(YellowBuilding);
            listOfBuildings.Add(GreenBuilding);

            city1.buildings = listOfBuildings;

            city1.mayor = "Heather Cleland";
            city1.est = 1774;

            foreach (Building building in listOfBuildings)
            {
                Console.WriteLine($"This building: {building.address} is in {city1.city}");
            }
        }
    }
}