using System;

namespace AbstractSchedule.Facade
{
    interface IScheduleUpdater
    {
        void UpdateBus(int _busID, TimeSpan _curTime, Tuple<double, double> _loc);
    }
}
