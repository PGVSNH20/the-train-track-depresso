using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainConsole
{
    public class Clock : IClock
    {
        private Thread clockThread;
        private static bool timeIsTicking;
        public static int minutesWhichHaveTicked;

        public Clock()
        {
            clockThread = new Thread(Tick);
            clockThread.IsBackground = true;
            timeIsTicking = false;
            minutesWhichHaveTicked = 0;
            clockThread.Start();
        }

        public void Start()
        {
            timeIsTicking = true;
        }

        public void Stop()
        {
            timeIsTicking = false;
        }

        private static void Tick()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (timeIsTicking)
                {
                    minutesWhichHaveTicked++;
                    Console.WriteLine($"Tick: {minutesWhichHaveTicked} min have passed");
                }

            }
        }
    }
}
