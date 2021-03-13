using System;
using System.IO;
using TrainEngine;

namespace TrainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Train track!");
            // Step 1:
            // Parse the traintrack (Data/traintrack.txt) using ORM (see suggested code)
            // Parse the trains (Data/trains.txt)

            // Step 2:
            // Make the trains run in treads

            Train train1 = new Train("Hogwarts Express");
            Station station1 = new Station("Westeros");
            Station station2 = new Station("Liverpool");

            ITravelPlan travelPlan = new TravelPlan(train1)
                    .DepartureAt(station1, "")
                    .ArrivalAt(station2, "10:23")
                .GeneratePlan();

            Console.WriteLine();
        }
    }
}
