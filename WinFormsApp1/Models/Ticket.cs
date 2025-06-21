namespace WinFormsApp1.Models
{
    public class Ticket
    {
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }

        public Ticket(Flight flight, Passenger passenger)
        {
            Flight = flight;
            Passenger = passenger;
        }
    }
}
