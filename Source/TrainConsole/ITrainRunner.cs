using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainEngine;

namespace TrainConsole
{
    public interface ITrainRunner
    {
        void Start(Station startStaion, Station endStaion);
        void Stop();
    }
}
