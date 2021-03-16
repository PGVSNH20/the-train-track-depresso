using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool EndStation { get; set; }
        public int Distance { get; set; }

        public Station()
        {

        }

        public Station(int id, string stationName, bool endStation)
        {
            Id = id;
            Name = stationName;
            EndStation = endStation;
        }
    }
}
