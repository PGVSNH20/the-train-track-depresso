using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    class TrainAPI
    {
        Train train1 = new Train("Hogwarts Express");
        Station station1 = new Station("Westeros");
        Station station2 = new Station("Liverpool");

        ITravelPlan travelPlan = new TrainPlaner(train1, station1)
                .HeadTowards(station2)
                .StartTrainAt("10:23")
                .StopTrainAt(station2, "14:53")
            .GeneratePlan();
    }
}
