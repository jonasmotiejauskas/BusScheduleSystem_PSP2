using System;
using System.Collections.Generic;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Facade
{
    interface IScheduleAnalizer
    {
        List<Bus> getBusList(int _stopID, DateTime _curTime);
    }
}
