using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TrainEngine
{
    public class EngineOrms
    {
        public TrackDescription ParseTrackDescription(string track)
        {
            throw new NotImplementedException();
        }

        public List<Passenger> ParsePassengers()
        {
            List<Passenger> passengers = new List<Passenger>();
            
            foreach (string row in File.ReadAllLines("..\\passengers.txt"))
            {
                string[] column = row.Split(';');
                Passenger passenger = new Passenger();
                passenger.Id = Int32.Parse(column[0]);
                passenger.FullName = column[1];
                passengers.Add(passenger);
            }
            return passengers;
        }

        public List<Train> ParseTrains()
        {
            List<Train> trains = new List<Train>();

            foreach (string row in File.ReadAllLines("..\\trains.txt"))
            {
                string[] column = row.Split(',');
                Train train = new Train();
                train.Id = Int32.Parse(column[0]);
                train.Name = column[1];
                train.MaxSpeed = Int32.Parse(column[2]);
                train.Operated = Boolean.Parse(column[3]);
                trains.Add(train);
            }
            return trains;
        }
    
        public List<Station> ParseStations()
        {
            List<Station> stations = new List<Station>();

            foreach (string row in File.ReadAllLines("..\\stations.txt")) // gör sökvägen relativ
            {
                string[] column = row.Split('|');
                Station station = new Station();
                station.Id = Int32.Parse(column[0]);
                station.StationName = column[1];
                station.EndStation = Boolean.Parse(column[2]);
                stations.Add(station);
            }

            return stations;
        }
    }
}