﻿using System;
using AbstractSchedule.Entities;
using System.Collections.Generic;

namespace AbstractSchedule.Services
{
    public interface IScheduleFactory
    {
        Schedule CreateSchedule(List<Tuple<BusStop, TimeSpan>> _regular, Bus _schedBus);
    }
}