using WinFormsApp1.Models;

public class Flight
{
    public int FlightNumber { get; set; }
    public string Route { get; set; }
    public int TotalSeats { get; set; }
    public int AvailableSeats { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public decimal Price { get; set; }

    public List<Passenger> Passengers { get; } = new();

    public Flight(int flightNumber, string route, int totalSeats, int price,
                  DateTime departureTime, DateTime arrivalTime)
    {
        FlightNumber = flightNumber;
        Route = route;
        Price = price; 
        TotalSeats = totalSeats;
        AvailableSeats = totalSeats;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
    }
}

