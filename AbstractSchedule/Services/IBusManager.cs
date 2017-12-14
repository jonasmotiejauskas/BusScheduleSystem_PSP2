using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;
using System;

namespace AbstractSchedule.Services
{
    interface IBusManager
    {
        BusStop FindNearestStop(Bus _bus);
        void UpdateArrivalTime(Bus _bus, TimeSpan _arrivalTime);
        void UpdateLocation(Bus _bus, Tuple<double, double> _newLoc);
    }
}
