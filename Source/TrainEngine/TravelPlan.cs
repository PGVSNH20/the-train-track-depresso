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

        public TravelPlan(Train train)
        {

        }

        public TravelPlan DepartureAt(Station currentStation, string departure)
        {
            return this;
        }

        public TravelPlan ArrivalAt(Station destination, string arrival)
        {
            return this;
        }

        public ITravelPlan GeneratePlan()
        {
            return this;
        }
    }
}
