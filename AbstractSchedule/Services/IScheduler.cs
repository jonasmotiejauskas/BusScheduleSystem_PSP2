using System;
using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    interface IScheduler
    {
        void UpdateSchedule(Schedule _targetSchedule);
        List<Bus> FindBusses(List<Schedule> _schedules, BusStop _targetStop, TimeSpan _current);
        List<Schedule> GetSchedulesForStop(BusStop _stop);
    }
}
