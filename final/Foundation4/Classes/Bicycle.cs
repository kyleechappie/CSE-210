//Additional property: Speed.
//Override methods: GetDistance(), GetSpeed(), GetPace().

public class Bicycle : Activity
{
    // Additional property
    private double speed;

    // Constructor
    public Bicycle(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        // Initialize additional property
        this.speed = speed;

    }

    // Override methods
    public override double GetDistance()
    {
        // Calculate distance
        distance = lengthInMinutes * 0.03048 * speed / 60;
    }

    public override double GetSpeed()
    {
        // Calculate speed
        speed = lengthInMinutes * 0.03048 / (double)date.Subtract(DateTime.Now).TotalHours;
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