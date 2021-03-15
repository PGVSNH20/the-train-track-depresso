using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainConsole
{
    public class Clock
    {
        public int hours;
        public int minutes;

        public Clock(int h, int m)
        {
            hours = h;
            minutes = m;
        }

        public void StartClock()
        {
            for(; minutes <= 60; minutes++)
            {
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                    if(hours == 24)
                    {
                        hours = 0;
                    }
                }
                Console.WriteLine(hours + ":" + minutes);
                Thread.Sleep(1000);
            }
        }
    }
}
