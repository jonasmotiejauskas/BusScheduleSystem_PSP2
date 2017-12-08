using System;
using System.Collections.Generic;

namespace AbstractSchedule.Entities
{
    public abstract class Schedule
    {
        public abstract List<Tuple<BusStop, TimeSpan>> RegularSchedule { get; set; }
        public abstract DateTime ScheduleDate { get; set; }
        public abstract Bus BusForSchedule { get; set; }
    } 
}
