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
            var klockan = new Clock();
            klockan.Start();

            List<Passenger> svejs = EngineOrms.ParsePassengers();
            foreach(var hej in svejs)
            {
                Console.WriteLine(hej.FullName);
                Thread.Sleep(100);
            }

            klockan.Stop();
            Console.WriteLine("hejsan svensjan");

            Console.ReadLine();
        }
    }
}