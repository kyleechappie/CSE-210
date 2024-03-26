//POLYMORPHISM PROJECT  

//Properties: Date, LengthInMinutes.
//Virtual methods: GetDistance(), GetSpeed(), GetPace().
//Method: GetSummary() to produce a summary string with all the information.

public class Activity
{
    // Properties
    private DateTime date;
    private int lengthInMinutes;

    // Constructor
    public Activity(DateTime date, int lengthInMinutes)
    {
        // Initialize properties
    }

    // Virtual methods
    public virtual double GetDistance()
    {
        // Calculate distance
    }

    public virtual double GetSpeed()
    {
        // Calculate speed
    }

    public virtual double GetPace()
    {
        // Calculate pace
    }

    // Method
    public virtual string GetSummary()
    {
        // Generate summary
    }
}