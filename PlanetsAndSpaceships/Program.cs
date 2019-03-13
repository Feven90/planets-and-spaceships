using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> LastTwoPlanets = new List<string> { "Uranus", "Neptune" };
            planetList.AddRange(LastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> spaceshipsVisitedMercury = new List<string>() { "Mariner", "MESSENGER", "BepiColombo" };
            List<string> spaceshipsVistitedVenus = new List<string>() { "Mariner", "Venera 6", "Cosmos 96" };
            List<string> spacesshipsVisitedMars = new List<string>() { "Viking", "Opportunity", "Curiosity" };
            var spaceship = new Dictionary<string, List<string>>
            {
                { "Mercury", spaceshipsVisitedMercury },
                { "Venus", spaceshipsVistitedVenus },
                { "Mars", spacesshipsVisitedMars }
            };

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            
            foreach (var planet in planetList)
            {
               // Console.WriteLine(planet);
                foreach (var (planetName, spaceShipsVisitedPlanets) in spaceship)
                {
                    if (planet == planetName)
                    {
                        Console.Write($"{planet}: ");
                        var space = "";
                        //Console.WriteLine($"{planetName} :");
                        foreach (var spaceShipVisitedPlanet in spaceShipsVisitedPlanets)
                        {
                            space += $"{spaceShipVisitedPlanet} ,";
                           // Console.Write($"{spaceShipVisitedMercury}, ");
                            Console.Write("");
                        }
                        Console.WriteLine(space);
                    }
                }
               

            }

            Console.Write("Rockey planets:");

            foreach (var rockyPlanet in rockyPlanets)
            {
               
                Console.Write($"{rockyPlanet },");
            }


           // var hello = new planetsListSpaceships();
           // hello.PlanetInfo();
           Console.ReadLine();
        }
     
    }
}
