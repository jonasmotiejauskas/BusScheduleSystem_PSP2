using AbstractSchedule.Entities;

namespace AbstractSchedule.Facade
{
    public interface IBusValidator
    {
        bool ValidateBus(Bus _bus);
    }
}
