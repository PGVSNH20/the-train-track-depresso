using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class TravelPlan : ITravelPlan
    {
        public List<object> TimeTable => throw new NotImplementedException();

        public object Train => throw new NotImplementedException();

        public void Load(string path)
        {
            throw new NotImplementedException();
        }

        public void Save(string path)
        {
            throw new NotImplementedException();
        }

        public TravelPlan(Train train, Station station1)
        {

        }

        public void DepartureAt(Station currentStation, string departure)
        {

        }

        public void ArriveAt(Station destination, string arrival)
        {

        }

        public void GeneratePlan()
        {

        }
    }
}
