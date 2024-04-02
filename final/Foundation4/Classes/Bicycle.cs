//Additional property: Speed.
//Override methods: GetDistance(), GetSpeed(), GetPace().

using System;
public class StationaryBicycles : Exercise
{
    private double _speed;

    public StationaryBicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bicycle";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}