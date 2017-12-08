using System;
using System.Collections.Generic;
using AbstractSchedule.Services;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Facade
{
    interface IScheduleUpdater
    {
        void UpdateBus(int _busID, TimeSpan _curTime, Tuple<double, double> _loc);
    }
}
