using System;
using AbstractSchedule.Entities;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    interface IRouteFactory
    {
        Route CreateRoute(List<Tuple<BusStop, TimeSpan>> _route);
    }
}
