using AbstractSchedule.Entities;
using System;

namespace AbstractSchedule.Services
{
    public interface BusManager
    {
        BusStop FindNearestStop(Bus _bus);
        void UpdateArrivalTime(Bus _bus, TimeSpan _arrivalTime);
        void UpdateLocation(Bus _bus, Tuple<double, double> _newLoc);
    }
}
