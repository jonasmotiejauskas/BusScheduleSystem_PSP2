﻿using System;
using System.Collections.Generic;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Facade
{
    interface IEntityRetriever
    {
        BusStop getBusStop(int _stopId);
    }
}
