using System;
using AbstractSchedule.Entities;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    public interface IScheduler
    {
        void UpdateSchedule(Schedule _targetSchedule);
        List<Bus> FindBusses(List<Schedule> _schedules, BusStop _targetStop, TimeSpan _current);
        List<Schedule> GetSchedulesForStop(BusStop _stop);
    }
}
