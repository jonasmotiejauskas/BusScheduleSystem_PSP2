using System;
using System.Collections.Generic;
using AbstractSchedule.Entities;

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
