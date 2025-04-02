public class OutdoorGathering : Event
{
    private string _weatherForcast;
    public OutdoorGathering(string eventTitle, string description, string eventDate, string time, Address address, string weatherForcast) : base(eventTitle, description, eventDate, time, address)
    {
        _weatherForcast = weatherForcast;
    }
    public override void fullDetailMessage()
    {
        throw new NotImplementedException();    
    }
    public override void shortDescription()
    {
        throw new NotImplementedException();
    }
}