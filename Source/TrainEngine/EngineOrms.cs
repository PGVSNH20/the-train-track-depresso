using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TrainEngine
{
    public class EngineOrms
    {
        public static List<Passenger> ParsePassengers()
        {
            List<Passenger> passengers = new List<Passenger>();

            string[] array = File.ReadAllLines(@"..\..\..\Data\passengers.txt");
            for (int i = 1; i < array.Length; i++)
            {
                string row = array[i];
                string[] column = row.Split(';');
                var passenger = new Passenger
                {
                    Id = Int32.Parse(column[0]),
                    FullName = column[1]
                };
                passengers.Add(passenger);
            }
            return passengers;
        }

        public static List<Train> ParseTrains()
        {
            List<Train> trains = new List<Train>();

            string[] array = File.ReadAllLines(@"..\..\..\Data\trains.txt");
            for (int i = 1; i < array.Length; i++)
            {
                string row = array[i];
                string[] column = row.Split(',');
                Train train = new Train
                {
                    Id = Int32.Parse(column[0]),
                    Name = column[1],
                    MaxSpeed = Int32.Parse(column[2]),
                    Operated = Boolean.Parse(column[3])
                };
                trains.Add(train);
            }
            return trains;
        }

        public static List<Station> ParseStations()
        {
            List<Station> stations = new List<Station>();

            string[] array = File.ReadAllLines(@"..\..\..\Data\stations.txt");
            for (int i = 1; i < array.Length; i++)
            {
                string row = array[i];
                string[] column = row.Split('|');
                Station station = new Station
                {
                    Id = Int32.Parse(column[0]),
                    Name = column[1],
                    EndStation = Boolean.Parse(column[2])
                };
                stations.Add(station);
            }

            return stations;
        }
    }
}