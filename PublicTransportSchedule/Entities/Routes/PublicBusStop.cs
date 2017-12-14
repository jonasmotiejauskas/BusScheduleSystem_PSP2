using System;
using AbstractSchedule.Entities.Routes;

namespace PublicTransportSchedule.Entities.Routes
{
    public class PublicBusStop : BusStop
    {
        public override Tuple<double, double> StopLocation { get; set; }
        public override string StopName { get; set; }
        public override int Direction { get; set; }
    }
}
