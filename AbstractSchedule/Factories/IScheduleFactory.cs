using System;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Services
{
    public interface IScheduleFactory
    {
        Schedule CreateSchedule(Route _regular, Bus _schedBus, DateTime _forTime);
    }
}
