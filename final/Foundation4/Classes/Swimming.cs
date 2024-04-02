//Additional property: Laps.
//Override methods: GetDistance(), GetSpeed(), GetPace().

using System;

public class Swimming : Exercise
{
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / _minutes * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / GetDistance();
        return pace;
    }
}
