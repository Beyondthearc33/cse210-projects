using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        events.Add(new Lectures("Ted Talk", "Expanding Science in your field", "September 12, 2022", "4:00 PM", new Address("3388 W Pond Dr", "Lehi", "Utah", "USA"), "John Brook", 300));

        events.Add(new Receptions("Wedding of Ryan & Janet", "Wedding", "July 20, 2025", "6:00PM", new Address("1422 East Parrot Dr", "Draper", "Utah", "USA"), "rsvp@OlympicEvent.com"));

        events.Add(new OutdoorGathering("Adams Reunion", "Adams Family Reunion", "July 4, 2025", "11:00 AM", new Address("1344 West Kremlin Street", "Cordova", "Maine", "USA"), "Cloudy"));

        foreach(Event e in events)
        {
            e.standardDetailMessage();
            Console.WriteLine();
            e.fullDetailMessage();
            Console.WriteLine();
            e.shortDescription();
        }
    }
}