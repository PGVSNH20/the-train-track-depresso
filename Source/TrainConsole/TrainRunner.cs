using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrainEngine;

namespace TrainConsole
{
    public class TrainRunner: ITrainRunner
    {
        private Thread simulatorThread;
        private Train trainToSimulate;
        private static bool simulatorIsRunning;

        public TrainRunner(Train train)
        {
            this.trainToSimulate = train;
            simulatorIsRunning = false;

        }

        public void Start(Station startStaion, Station endStaion)
        {
            int distance = endStaion.Distance - startStaion.Distance;
            Console.WriteLine($"Starting {trainToSimulate.Name} going from {startStaion.Name} to {endStaion.Name}, a distance of {distance} km");
            simulatorIsRunning = true;
            simulatorThread = new Thread(() => Simulate(trainToSimulate, distance));
            simulatorThread.Start();
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping {trainToSimulate.Name}");
            simulatorIsRunning = false;
        }

        private static void Simulate(Train tts, int distanceToDrive)
        {
            while (simulatorIsRunning)
            {

                int distanceDrived = tts.MaxSpeed * Clock.minutesWhichHaveTicked;
                Console.WriteLine($"So far have {tts.Name} gone {distanceDrived} in {Clock.minutesWhichHaveTicked} min");
                if (distanceDrived >= distanceToDrive)
                {
                    simulatorIsRunning = false;
                    Console.WriteLine($"We have arrived at the station which is {distanceToDrive} km from starting point");
                }
                Thread.Sleep(200);
            }
        }
    }
}
