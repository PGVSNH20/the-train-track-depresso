using System;
using System.Collections.Generic;
using System.Threading;
using TrainEngine;

namespace TrainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> svejs = EngineOrms.ParsePassengers();
            foreach(var hej in svejs)
            {
                Console.WriteLine(hej.FullName);
            }

            Console.ReadLine();
        }
    }
}