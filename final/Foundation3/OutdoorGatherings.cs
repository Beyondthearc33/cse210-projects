public class OutdoorGathering : Event
{
    private string _weatherForcast;
    public OutdoorGathering(string eventTitle, string description, string eventDate, string time, Address address, string weatherForcast) : base(eventTitle, description, eventDate, time, address)
    {
        _weatherForcast = weatherForcast;
    }
    public override void fullDetailMessage()
    {
        Console.WriteLine($"Outdoor Gathering\nThe weather Forcast is {_weatherForcast}");  
        standardDetailMessage();
    }
    public override void shortDescription()
    {
        Console.WriteLine($"Outdoor Gathering Event\n{_eventTitle}\n{_eventDate}");
    }
}