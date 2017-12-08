using System;
using System.Collections.Generic;

namespace AbstractSchedule.Entities
{
    public abstract class Route
    {
        List<Tuple<BusStop, TimeSpan>> RegularRoute { get; set; }
    }
}
