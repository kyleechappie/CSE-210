public class OutdoorGathering : Event
{
    // Additional property
    private string weatherForecast;

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        // Initialize additional property
    }

    // Override GenerateFullDetailsMessage() to include weather forecast
    public override string GenerateFullDetailsMessage()
    {
        // Generate full details message for an outdoor gathering
    }
}
