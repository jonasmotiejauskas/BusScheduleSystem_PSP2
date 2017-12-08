using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractSchedule.Entities;

namespace AbstractSchedule.Facade
{
    interface IEntityDepositor
    {
        void UpdateBus(int _busID, Bus _bus);
        void UpdateSchedule(int _scheduleID, Schedule _schedule);
        void UpdateRoute(int _roadID, Route _route);
        void UpdateBusStop(int _stopID, BusStop _stop);

        int CreateBus(Bus _bus);
        int CreateSchedule(Schedule _schedule);
        int CreateRoute(Route _route);
        int CreateBusStop(BusStop _stop);
    }
}
