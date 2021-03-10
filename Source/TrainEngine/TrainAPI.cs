using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TrainAPI
    {
        Train train1 = new Train("Name of train");
        Station station1 = new Station("Gothenburg");
        Station station2 = new Station("Stockholm");

        ITravelPlan travelPlan = new TrainPlaner(train1, station1)
                .HeadTowards(station2)
                .StartTrainAt("10:23")
                .StopTrainAt(station2, "14:53")
            .GeneratePlan();
    }
}
