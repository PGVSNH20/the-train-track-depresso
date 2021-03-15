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

            //            The stations placement eg: [1]
            //            The start station: *
            //            Tracks: -, / and \
            //            Railroad switches: < and >
            //            Level crossing (vägbom): = 
            throw new NotImplementedException();
        }

        public List<Passenger> ParsePassengers()
        {
            List<Passenger> passengers = new List<Passenger>();

            string[] array = File.ReadAllLines("..\\passengers.txt");
            for (int i = 1; i < array.Length; i++)
            {
                string row = array[i];
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

            string[] array = File.ReadAllLines("..\\trains.txt");
            for (int i = 1; i < array.Length; i++)
            {
                string row = array[i];
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

            string[] array = File.ReadAllLines("..\\stations.txt");
            for (int i = 1; i < array.Length; i++) // gör sökvägen relativ
            {
                string row = array[i];
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