using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleStopWatch
{
    public class ScheduleData
    {
        public String Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public ScheduleData( String name , int year , int month , int day )
        {
            this.Name = name;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
    }
}
