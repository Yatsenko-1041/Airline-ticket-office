using TicketSystem.Models;

public class AirportSystem
{
    public TicketOffice TicketOffice { get; private set; }

    public AirportSystem()
    {
        TicketOffice = new TicketOffice();
        InitializeTestData();
    }

    private void InitializeTestData()
    {
        var airport = new Airport
        {
            Name = "Boryspil",
            City = "Kyiv",
            Country = "Ukraine"
        };

        TicketOffice.Flights.Add(new Flight
        {
            FlightNumber = 1001,
            Route = "Kyiv - Warsaw",
            StopoverPoints = new List<string> { "Lviv" },
            DepartureTime = DateTime.Now.AddHours(2),
            DaysOfOperation = "Mon, Wed, Fri",
            AvailableSeats = 10,
            Airport = airport
        });

        TicketOffice.Flights.Add(new Flight
        {
            FlightNumber = 1002,
            Route = "Kyiv - Berlin",
            StopoverPoints = new List<string> { "Lviv", "Krakow" },
            DepartureTime = DateTime.Now.AddHours(5),
            DaysOfOperation = "Tue, Thu, Sat",
            AvailableSeats = 8,
            Airport = airport
        });
    }
}
