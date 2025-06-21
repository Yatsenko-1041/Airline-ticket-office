namespace WinFormsApp1.Models
{
    public class TicketOffice
    {
        public List<Flight> Flights { get; } = new();
        public List<Ticket> Tickets { get; } = new();

        public TicketOffice()
        {
            // Прикладові рейси
            Flights.Add(new Flight(101, "Київ - Варшава", 50, 100,
                 new DateTime(2025, 6, 21, 8, 0, 0),
                 new DateTime(2025, 6, 21, 9, 10, 0)));

            Flights.Add(new Flight(102, "Варшава - Мадрид", 60, 150,
                new DateTime(2025, 6, 21, 9, 30, 0),
                new DateTime(2025, 6, 21, 11, 20, 0)));

            Flights.Add(new Flight(103, "Варшава - Харків", 55, 120,
                new DateTime(2025, 6, 21, 11, 0, 0),
                new DateTime(2025, 6, 21, 12, 20, 0)));
        }

        public Flight? FindNextFlight(string destination)
        {
            return Flights
                .Where(f => f.Route == destination && f.AvailableSeats > 0)
                .OrderBy(f => f.FlightNumber)
                .FirstOrDefault();
        }

        public void SellTicket(Flight flight, Passenger passenger)
        {
            if (flight.AvailableSeats <= 0) return;

            flight.Passengers.Add(passenger);
            flight.AvailableSeats--;

            Tickets.Add(new Ticket(flight, passenger));
        }

        public string GetPassengerManifest(Flight flight)
        {
            if (flight.Passengers.Count == 0)
                return "Немає пасажирів.";

            return string.Join("\n", flight.Passengers.Select(p => p.FullName));
        }
    }
}


