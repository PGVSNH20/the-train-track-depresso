using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface ITrainFileOrm
    {
        List<Train> Trains { get; }

        void Load();
        

    }
}
