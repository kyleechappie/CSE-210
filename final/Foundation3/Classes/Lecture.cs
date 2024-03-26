public class Lecture : Event
{
    // Additional properties
    private string speaker;
    private int capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        // Initialize additional properties
    }

    // Override GenerateFullDetailsMessage() to include speaker name and capacity
    public override string GenerateFullDetailsMessage()
    {
        // Generate full details message for a lecture
    }
}
