namespace WebApplication1.Models
{
    public interface IPassangerRepository
    {
        Passenger CreatePassanger(Passenger passenger);
        Passenger UpdatePassanger(int Id, Passenger passenger);
        void DeletePassanger(int Id);
        List<Passenger> GetAll();
        Passenger GetPassengerById(int id);
    }
}
