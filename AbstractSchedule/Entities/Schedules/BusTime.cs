using System;
using AbstractSchedule.Entities.Routes;

namespace AbstractSchedule.Entities.Schedules
{
    public abstract class BusTime : Entity
    {
        public abstract BusStop BusStop { get; set; }
        public abstract TimeSpan ArrivalTime { get; set; }
    }
}
