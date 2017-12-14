using AbstractSchedule.Entities.Routes;
using AbstractSchedule.Entities.Schedules;

namespace AbstractSchedule.Facade
{
    interface IEntityDepositor
    {
        void UpdateBus(int _busID, Bus _bus);
        void UpdateSchedule(int _scheduleID, Schedule _schedule);
        void UpdateRoute(int _roadID, Route _route);
        void UpdateBusStop(int _stopID, BusStop _stop);

        void DeleteBus(int _busID, Bus _bus);
        void DeleteSchedule(int _scheduleID, Schedule _schedule);
        void DeleteRoute(int _roadID, Route _route);
        void DeleteBusStop(int _stopID, BusStop _stop);

        int CreateBus(Bus _bus);
        int CreateSchedule(Schedule _schedule);
        int CreateRoute(Route _route);
        int CreateBusStop(BusStop _stop);
    }
}
