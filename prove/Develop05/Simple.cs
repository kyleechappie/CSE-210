using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(){

    }

    public SimpleGoal(string name, string description, int pointValue, bool completion){
        name = Name;
        description = Description;
        pointValue = PointValue;
        completion = Completion;
    }

    public override void CompleteGoal(GoalManager goalManager)
    {
        Completion = true;
        goalManager.addToScore(PointValue);
    }
    // Method to display information about the simple goal

    public override string FormatGoal()
    {
        return $"simple|{Name}|{Description}|{PointValue}|{Completion}";
    }

}
