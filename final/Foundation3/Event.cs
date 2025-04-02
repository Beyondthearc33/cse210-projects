using System.Diagnostics;

public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _eventDate;
    protected string _time;
    protected Address _address;
    public Event(string eventTitle, string description, string eventDate, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _eventDate = eventDate;
        _time = time;
        _address = address;

    }
    public void standardDetailMessage()
    {
        Console.WriteLine($"Standard Detail:\n   {_eventTitle}\n   {_description}\n   {_eventDate}\n   {_time}\n   {_address}");
    }
    public abstract void fullDetailMessage();
    public abstract void shortDescription();

}