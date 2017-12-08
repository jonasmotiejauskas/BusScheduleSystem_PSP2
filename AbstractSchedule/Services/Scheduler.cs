using System;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Services
{
    public interface Scheduler
    {
        void UpdateSchedule(Schedule _targetSchedule);

    }
}
