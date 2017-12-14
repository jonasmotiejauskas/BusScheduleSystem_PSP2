using System;
using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;

namespace AbstractSchedule.Facade
{
    interface IEntityRetriever
    {
        BusStop GetBusStop(int _stopID);
        Bus GetBus(int _busID);
        Schedule GetSchedule(int _scheduleID);
        Route GetRoute(int _RouteID);

        Schedule GetScheduleByBus(int _busID, DateTime _curDate);
        int GetScheduleID(Schedule _schedule);
    }
}
