using System;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Services
{
    interface BusFactory
    {
        Bus createBus(string _regNum, TimeSpan _depTime, string _busNum, int _seatCount);
    }
}
