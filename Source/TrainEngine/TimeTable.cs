using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrainEngine
{
    public class TimeTable
    {
        public int TrainId { get; set; }
        public int StationID { get; set; }

        public string DepartureTime { get; set; }
        //Omvandla till int senare (split timmar och min)

        public string ArrivalTime { get; set; }
        //Omvandla till int senare


        public List<TimeTable> Read()
        {
            List<TimeTable> timetables = new List<TimeTable>();

            foreach (string row in File.ReadAllLines("..\\TimeTable.txt"))
            {
                string[] column = row.Split(';');

                TimeTable timetable = new TimeTable();
                timetable.TrainId = Int32.Parse(column[0]);
                timetable.StationID = Int32.Parse(column[1]);
                timetable.DepartureTime = column[2];
                timetable.ArrivalTime = column[3];

                timetables.Add(timetable);
            }
            return timetables;
        }




        public void Write()
        {

        }



    }
}





