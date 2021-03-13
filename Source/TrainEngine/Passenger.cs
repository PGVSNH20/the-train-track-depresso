using System;
using System.Collections.Generic;
using System.Text;

namespace TrainEngine
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Passenger()
        {

        }

        public Passenger(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}
