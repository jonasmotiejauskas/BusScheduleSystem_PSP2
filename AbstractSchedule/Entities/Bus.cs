using System;

namespace AbstractSchedule.Entities
{
    public abstract class Bus
    {
        public abstract int RegistrationNumber { get; set; }
        public abstract int NumberOfSeats { get; set; }
        public abstract string BusNumber { get; set; }
        public abstract TimeSpan Departure { get; set; }
        public abstract TimeSpan Arrival { get; set; }
        public abstract Tuple<double, double> CurrentLocation { get; set; }
        public abstract void StartTrip(TimeSpan _time);
    }
}
