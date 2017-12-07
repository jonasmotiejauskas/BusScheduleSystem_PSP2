using System;

namespace AbstractSchedule.Entities
{
    public abstract class BusStop
    {
        public abstract Tuple<double, double> StopLocation { get; set; }
        public abstract string StopName { get; set; }
    }
}
