//Additional property: Laps.
//Override methods: GetDistance(), GetSpeed(), GetPace().

public class Swimming : Activity
{
    // Additional property
    private int laps;

    // Constructor
    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        // Initialize additional property
        this.laps = laps;
    }

    // Override methods
    public override double GetDistance()
    {
        // Calculate distance
        distance = lengthInMinutes * 0.62;
    }

    public override double GetSpeed()
    {
        // Calculate speed
        speed = lengthInMinutes * 0.62 / (double)date.Subtract(DateTime.Now).TotalHours;
    }

    public override double GetPace()
    {
        // Calculate pace
        return 60.0 / (GetSpeed() / 3600.0);
    }

    // Method
    public override string GetSummary()
    {
        // Generate summary

    }
}
