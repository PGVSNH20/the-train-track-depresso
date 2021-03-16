using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public interface IStationFileORM
    {
       List<Station> Stations { get; }
        void Load();
        void Save();
    }   
}
