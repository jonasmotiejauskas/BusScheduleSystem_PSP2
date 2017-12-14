using System;
using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    interface IRouteFactory
    {
        Route CreateRoute(List<BusTime> _route);
        BusStop CreateBusStop(string _stopName, Tuple<double, double> _loc, int _dir);
    }
}