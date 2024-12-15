using System;
using System.Collections.Generic;
namespace HomePage{
struct FlightDetail
{
    public string FlightNumber { get; set; }
    public string FlightName { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Time { get; set; }
    public double Price { get; set; }
}

class InternationalFlights: IFlightDetails
{
    internal List<FlightDetail> flights;
    public InternationalFlights()
    {
        // Create a list to store flight instances
        this.flights = new List<FlightDetail>();

        // Add flight details
        this.flights.Add(new FlightDetail { FlightNumber = "F101", FlightName = "Skyline Airways", From = "New York", To = "Los Angeles", Time = "10:00 AM", Price = 30000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F102", FlightName = "Oceanic Airlines", From = "London", To = "Paris", Time = "1:00 PM", Price = 15000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F103", FlightName = "Aussie Express", From = "Sydney", To = "Melbourne", Time = "5:00 PM", Price = 10000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F104", FlightName = "Desert Eagle", From = "Mumbai", To = "Dubai", Time = "8:00 PM", Price = 40000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F105", FlightName = "Eastern Wings", From = "Tokyo", To = "Seoul", Time = "6:30 AM", Price = 20000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F106", FlightName = "Pacific Breeze", From = "San Francisco", To = "Honolulu", Time = "4:15 PM", Price = 35000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F107", FlightName = "EuroConnect", From = "Berlin", To = "Amsterdam", Time = "11:15 AM", Price = 12000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F108", FlightName = "Golden Route", From = "Singapore", To = "Bangkok", Time = "3:20 PM", Price = 18000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F109", FlightName = "Polar Air", From = "Reykjavik", To = "Oslo", Time = "6:00 AM", Price = 25000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F110", FlightName = "TransAtlantic", From = "Miami", To = "London", Time = "9:30 PM", Price = 55000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F111", FlightName = "Arctic Wings", From = "Anchorage", To = "Seattle", Time = "7:45 AM", Price = 22000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F112", FlightName = "Southern Comfort", From = "Cape Town", To = "Johannesburg", Time = "12:30 PM", Price = 18000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F113", FlightName = "Silk Route Express", From = "Beijing", To = "Shanghai", Time = "3:00 PM", Price = 12000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F114", FlightName = "Blue Skyways", From = "Mexico City", To = "Toronto", Time = "8:00 AM", Price = 45000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F115", FlightName = "Tropic Breeze", From = "Rio de Janeiro", To = "Buenos Aires", Time = "2:20 PM", Price = 23000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F116", FlightName = "Northern Star", From = "Moscow", To = "Saint Petersburg", Time = "6:15 PM", Price = 13000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F117", FlightName = "Safari Wings", From = "Nairobi", To = "Addis Ababa", Time = "10:30 AM", Price = 32000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F118", FlightName = "Outback Express", From = "Perth", To = "Darwin", Time = "8:40 AM", Price = 40000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F119", FlightName = "Aurora Line", From = "Helsinki", To = "Stockholm", Time = "11:50 AM", Price = 14000 });
        this.flights.Add(new FlightDetail { FlightNumber = "F120", FlightName = "Coastal Airways", From = "Los Angeles", To = "San Diego", Time = "5:30 PM", Price = 10000 });

    }
    public void ShowFlightDetails()
    {
        Console.WriteLine("\n--- Available InternationalFlights ---");
        foreach (var flight in this.flights)
        {
            Console.WriteLine($"Flight: {flight.FlightNumber} | Name: {flight.FlightName} | From: {flight.From} | To: {flight.To} | Time: {flight.Time} | Price: {flight.Price} Rs.");
            Thread.Sleep(100);
        }
    }

    public bool SearchFlight(string dateOfJourney,string source,string destination){

        return true;
    }
}

class LocalFlights : IFlightDetails
{
    internal List<FlightDetail> flights;
    public LocalFlights()
    {
        // Create a list to store flight instances
        flights = new List<FlightDetail>();

        // Add local flight details
        this.flights.Add(new FlightDetail { FlightNumber = "LF101", FlightName = "Air India", From = "Delhi", To = "Mumbai", Time = "9:00 AM", Price = 4500 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF102", FlightName = "IndiGo", From = "Bangalore", To = "Hyderabad", Time = "11:00 AM", Price = 3200 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF103", FlightName = "SpiceJet", From = "Chennai", To = "Kolkata", Time = "2:00 PM", Price = 4000 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF104", FlightName = "GoAir", From = "Pune", To = "Ahmedabad", Time = "6:30 PM", Price = 2800 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF105", FlightName = "Vistara", From = "Delhi", To = "Lucknow", Time = "8:45 AM", Price = 2400 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF106", FlightName = "AirAsia", From = "Mumbai", To = "Goa", Time = "4:00 PM", Price = 3500 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF107", FlightName = "Alliance Air", From = "Kochi", To = "Trivandrum", Time = "10:30 AM", Price = 1500 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF108", FlightName = "TruJet", From = "Jaipur", To = "Udaipur", Time = "3:00 PM", Price = 2000 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF109", FlightName = "Star Air", From = "Bhopal", To = "Indore", Time = "12:00 PM", Price = 1800 });
        this.flights.Add(new FlightDetail { FlightNumber = "LF110", FlightName = "Akasa Air", From = "Nagpur", To = "Raipur", Time = "5:15 PM", Price = 2200 });

    }

    public void ShowFlightDetails()
    {
        Console.WriteLine("\n--- Available LocalFlights ---");
        foreach (var flight in this.flights)
        {
            Console.WriteLine($"Flight: {flight.FlightNumber} | Name: {flight.FlightName} | From: {flight.From} | To: {flight.To} | Time: {flight.Time} | Price: {flight.Price} Rs.");
            Thread.Sleep(100);
        }
    }
    public bool SearchFlight(string dateOfJourney,string source,string destination){
        
        return true;
    }

}
}