public class Receptions : Event
{
    private string _rsvpEmail;
    public Receptions(string eventTitle, string description, string eventDate, string time, Address address, string rsvpEmail) : base(eventTitle, description, eventDate, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override void fullDetailMessage()
    {
        Console.WriteLine($"Reception\nRSVP @ {_rsvpEmail}");  
        standardDetailMessage();
    }
    public override void shortDescription()
    {
        Console.WriteLine($"Reception Event\n{_eventTitle}\n{_eventDate}");
    }
}