using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using TrainEngine;

namespace TrainConsole
{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("Train track!");
    //            Step 1:
    //             Parse the traintrack(Data / traintrack.txt) using ORM (see suggested code)
    //             Parse the trains(Data / trains.txt)

    //             Step 2:
    //             Make the trains run in treads

    //            Train train1 = new Train("Hogwarts Express");
    //            Station station1 = new Station("Westeros");
    //            Station station2 = new Station("Liverpool");

    //            ITravelPlan travelPlan = new TravelPlan(train1)
    //                    .DepartureAt(station1, "")
    //                    .ArrivalAt(station2, "10:23")
    //                .GeneratePlan();

    //            Console.WriteLine();
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new(10, 20);
            Thread thread1 = new(new ThreadStart(myClock.StartClock));
            thread1.Start();

            List<TimeTable> timeTable = TimeTable.Read();
            foreach (var ex in timeTable) {
                List<Train> trains = EngineOrms.ParseTrains();
                foreach (var train in trains)
                {
                    if (ex.TrainId == train.Id)
                    {
                        Console.WriteLine(train.Name);
                    }
                }
            }

            //List<TimeTable> timetables = new();

            //string pathToTxt = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\timetable.txt";
            //string[] array = File.ReadAllLines(pathToTxt);
            //for (int i = 1; i < array.Length; i++)

            //{
            //    string row = array[i];
            //    string[] column = row.Split(',');

            //    TimeTable timetable = new()
            //    {
            //        TrainId = int.Parse(column[0]),
            //        StationID = int.Parse(column[1]),
            //        DepartureTime = column[2],
            //        ArrivalTime = column[3]
            //    };
            //    timetables.Add(timetable);

            //    Console.WriteLine("\nTrain ID: " + timetable.TrainId + "\nStation ID: " + timetable.StationID + "\nDeparture time: " + timetable.DepartureTime + "\nArrival time: " + timetable.ArrivalTime);
        }
    }



    // !!SKRIVER UT TÅGINFO!!
    //class Program
    //{
    //    static void Main(string[] args)
    //    {


    //        List<Train> trains = new List<Train>();
    //        string pathToTxt = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\trains.txt";
    //        foreach (string row in File.ReadAllLines(pathToTxt))
    //        {
    //            string[] column = row.Split(',');
    //            Train train = new Train();
    //            train.Id = Int32.Parse(column[0]);
    //            train.Name = column[1];
    //            train.MaxSpeed = Int32.Parse(column[2]);
    //            train.Operated = Boolean.Parse(column[3]);
    //            trains.Add(train);

    //            Console.WriteLine("\nTrain ID: " + train.Id + "\nTrain name: " + train.Name + "\nTrain max speed: " + train.MaxSpeed + "\nTrain is operated: " + train.Operated);
    //        }


    //    }
    //}

    }