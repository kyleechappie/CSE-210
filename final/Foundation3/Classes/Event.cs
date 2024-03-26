//Properties: Title, Description, Date, Time, Address.
//Methods:
    //GenerateStandardDetailsMessage(): Returns a string with standard details of the event.
    //GenerateFullDetailsMessage(): Returns a string with full details of the event.
    //GenerateShortDescriptionMessage(): Returns a string with a short description of the event type, title, and date.

public class Event
{
    // Properties
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    // Constructor
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        // Initialize properties
    }

    // Methods to generate marketing messages
    public string GenerateStandardDetailsMessage()
    {
        // Generate standard details message
    }

    public virtual string GenerateFullDetailsMessage()
    {
        // Generate full details message
    }

    public virtual string GenerateShortDescriptionMessage()
    {
        // Generate short description message
    }
}
