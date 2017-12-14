using System;
using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;

namespace AbstractSchedule.Services
{
    interface IScheduleFactory
    {
        Schedule CreateSchedule(Route _regular, Bus _schedBus, DateTime _forTime);
        Bus CreateBus(string _regNum, string _busNum);
        BusTime CreateBusTime(BusStop _busStop, TimeSpan _arrival);
    }
}