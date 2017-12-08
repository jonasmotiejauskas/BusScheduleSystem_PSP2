using System;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Services
{
    interface IBusFactory
    {
        Bus CreateBus(string _regNum, string _busNum);
    }
}
