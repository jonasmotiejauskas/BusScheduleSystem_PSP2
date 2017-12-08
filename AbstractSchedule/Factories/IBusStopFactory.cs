using System;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Services
{
    interface IBusStopFactory
    {
        BusStop CreateBusStop(string _stopName, Tuple<double, double> _loc, int _dir);
    }
}
