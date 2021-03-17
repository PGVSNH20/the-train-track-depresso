using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainEngine
{
    public class StationFileORM : IStationFileORM
    {
        private string StationFileName;
        public StationFileORM(string filename)
        {
            this.StationFileName = filename;
            Stations = new List<Station>();
        }
        public List<Station> Stations { get; private set; }

        public void Load()
        {
            var stationLines = System.IO.File.ReadAllLines(@"..\..\..\Data\stations.txt");
            Console.WriteLine($"Reading file {StationFileName}");
            Stations = new List<Station>();

            foreach (var stationLine in stationLines)
            {
                var stationParts = stationLine.Split(new char[] { ';' });

                if (stationParts == null || stationParts.Length != 2)
                {
                    throw new Exception("Wrong data format");
                }

                Stations.Add(new Station()
                {
                    Name = stationParts[0],
                    Distance = int.Parse(stationParts[1])
                });
            }
        }

        public void Save()
        {
            System.IO.File.WriteAllLines(StationFileName, Stations.Select(x => x.ToString()));
        }
    }
}

