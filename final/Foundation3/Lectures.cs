public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string eventTitle, string description, string eventDate, string time, Address address, string speaker, int capacity) : base(eventTitle, description, eventDate, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
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