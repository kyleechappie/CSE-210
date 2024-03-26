public class Reception : Event
{
    // Additional property
    private string rsvpEmail;

    // Constructor
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        // Initialize additional property
    }

    // Override GenerateFullDetailsMessage() to include RSVP email
    public override string GenerateFullDetailsMessage()
    {
        // Generate full details message for a reception
    }
}
