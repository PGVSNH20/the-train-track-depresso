using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Station
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public bool EndStation { get; set; }

        public Station()
        {

        }

        public Station(int id, string stationName, bool endStation)
        {
            Id = id;
            StationName = stationName;
            EndStation = endStation;
        }
    }
}
