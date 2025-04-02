public class Receptions : Event
{
    private string _rsvpEmail;
    public Receptions(string eventTitle, string description, string eventDate, string time, Address address, string rsvpEmail) : base(eventTitle, description, eventDate, time, address)
    {
        _rsvpEmail = rsvpEmail;
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