namespace WebApplication1.Models
{
    public class PassangerRepository : IPassangerRepository
    {
        public List<Passenger> Passes = new() {
            new Passenger
            {
                Id = 1,
                PassangerName = "Amin",
                PassengerLastName = "Seifoori",
                FlightDate = new DateOnly(),
                FlightTime = new TimeOnly(),
                Comment = "New Comment"
            },
            new Passenger
            {
                Id = 2,
                PassangerName = "Reza",
                PassengerLastName = "Seifoori",
                FlightDate = new DateOnly(),
                FlightTime = new TimeOnly(),
                Comment = "New Comment"
            },
            new Passenger
            {
                Id = 3,
                PassangerName = "Salar",
                PassengerLastName = "Seifoori",
                FlightDate = new DateOnly(),
                FlightTime = new TimeOnly(),
                Comment = "New Comment"
            }
        };
        public Passenger CreatePassanger(Passenger passenger)
        {
            Passes.Add(passenger);
            return passenger;
        }

        public void DeletePassanger(int Id)
        {
            var pass = Passes.FirstOrDefault(x => x.Id == Id);
            Passes.Remove(pass);
        }

        public List<Passenger> GetAll()
        {
            return Passes;
        }

        public Passenger GetPassengerById(int id)
        {
            return Passes.FirstOrDefault(x => x.Id == id);
        }

        public Passenger UpdatePassanger(int Id, Passenger passenger)
        {
            var pass = Passes.FirstOrDefault(x => x.Id == Id);
            if (pass != null)
            {
                pass.PassangerName = passenger.PassangerName;
                pass.PassengerLastName = passenger.PassengerLastName;
                pass.FlightTime = passenger.FlightTime;
                pass.FlightDate = passenger.FlightDate;
                pass.Comment = passenger.Comment;
            }
            return passenger;
        }
    }
}
