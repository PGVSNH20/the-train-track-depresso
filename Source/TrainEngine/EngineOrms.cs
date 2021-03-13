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

        public Train ParseTrains()
        {
            throw new NotImplementedException();
        }

        public List<Station> ParseStations()
        {
            List<Station> stations = new List<Station>();

            foreach (string row in File.ReadAllLines("C:\\Projects\\Trainwreck\\Data\\stations.txt")) // gör sökvägen relativ
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