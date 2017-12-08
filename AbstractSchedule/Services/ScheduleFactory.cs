using System;
using AbstractSchedule.Entities;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    public interface ScheduleFactory
    {
        Schedule createSchedule(List<Tuple<BusStop, TimeSpan>> _regular, Bus _schedBus);
    }
}
