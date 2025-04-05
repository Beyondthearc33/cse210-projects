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
        Console.WriteLine($"Lectures\nGuest Speaker: {_speaker}\n Event Capacity is {_capacity}");  
        standardDetailMessage();    
    }
    public override void shortDescription()
    {
        Console.WriteLine($"Lecture Event\n{_eventTitle}\n{_eventDate}");
    }
}