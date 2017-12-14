using System;
using System.Collections.Generic;
using AbstractSchedule.Entities.Schedules;

namespace AbstractSchedule.Facade
{
    interface IScheduleAnalizer
    {
        List<Bus> getBusList(int _stopID, DateTime _curTime);
    }
}
