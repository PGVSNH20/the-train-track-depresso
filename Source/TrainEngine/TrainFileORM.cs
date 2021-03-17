using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TrainFileORM : ITrainFileOrm
    {
        private string trainFile;

        public TrainFileORM(string trainFile)
        {
            this.trainFile = trainFile;
        }

        public List<Train> Trains { get; private set; }

        public void Load()
        {
            var stationLines = System.IO.File.ReadAllLines(@"..\..\..\Data\trains.txt");
            Console.WriteLine($"Reading file {trainFile}");
            Trains = new List<Train>();

            foreach (string stationLine in stationLines)
            {
                string[] stationParts = stationLine.Split(new char[] { ';' });

                if (stationParts == null || stationParts.Length != 2)
                {
                    throw new Exception("Wrong data format");
                }

                Trains.Add(new Train()
                {
                    Name = stationParts[0],
                    MaxSpeed = int.Parse(stationParts[1])
                });
            }
        }
    }
}

