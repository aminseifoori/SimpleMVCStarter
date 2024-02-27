namespace WebApplication1.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string PassangerName { get; set; }
        public string PassengerLastName { get; set; }
        public DateOnly FlightDate { get; set; }
        public TimeOnly FlightTime { get; set; }
        public string Comment { get; set; }
    }
}
