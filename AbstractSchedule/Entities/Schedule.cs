using System;

namespace AbstractSchedule.Entities
{
    public abstract class Schedule
    {
        public abstract Route RegularSchedule { get; set; }
        public abstract DateTime ScheduleDate { get; set; }
        public abstract Bus BusForSchedule { get; set; }
    } 
}
