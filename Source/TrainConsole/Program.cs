using System;
using System.Collections.Generic;
using System.Threading;
using TrainConsole;
using TrainEngine;

namespace orm_thread_demo_v
{
    class Program
    {
        static void Main(string[] args)
        {
            IStationFileORM stationOrm = new StationFileORM("stations.txt");
            stationOrm.Load();
            WriteStations(stationOrm.Stations);


            ITrainFileOrm trainOrm = new TrainFileORM("trains.txt");
            trainOrm.Load();

            // stationOrm.Stations.Add(new Station(){
            //     Name = "Station 4",
            //     Distance = 683
            // });
            // stationOrm.Save();

            ITrainRunner runner = new TrainRunner(trainOrm.Trains[0]);
            runner.Start(stationOrm.Stations[0], stationOrm.Stations[1]);

            IClock fakeClock = new Clock();
            fakeClock.Start();

            Thread.Sleep(3000);
            Console.WriteLine("Times up");
            runner.Stop();
        }

        private static void WriteStations(List<Station> stations)
        {
            Console.WriteLine("--- Stations");
            foreach (var station in stations)
            {
                Console.WriteLine($"{station.Name} is {station.Distance} km away");
            }
        }
    }
}