using System;
using AbstractSchedule.Entities;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    public interface IScheduleFactory
    {
        Schedule CreateSchedule(Route _regular, Bus _schedBus);
    }
}
