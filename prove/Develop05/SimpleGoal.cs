using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(){

    }

    public SimpleGoal(string name, string description, int pointValue, bool completion){
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _completion = completion;
    }

    public override void CompleteGoal(GoalManager goalManager)
    {
        _completion = true;
        goalManager.addToScore(_pointValue);
    }
    // Method to display information about the simple goal

    public override string FormatGoal()
    {
        return $"simple|{_name}|{_description}|{_pointValue}|{_completion}";
    }

}
