//Additional property: Distance.
//Override methods: GetDistance(), GetSpeed(), GetPace().

using System;

public class Running : Exercise
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}