using System;

namespace AbstractSchedule.Entities
{
    public abstract class BusStop : Entity
    {
        public abstract Tuple<double, double> StopLocation { get; set; }
        public abstract string StopName { get; set; }
        public int Direction;
    }
}
