using System;

public class EternalGoal : Goal
{

    public EternalGoal()
    {
        
    }

    public EternalGoal(string name, string description, int pointValue) //whats the ish??
    {
        name = Name;
        description = Description;
        pointValue = PointValue;
    }
    //if goal is completed add points to score
        public override void CompleteGoal(GoalManager goalManager)
    {
        Completion = false;
        goalManager.addToScore(PointValue);


    }
    // will not check box if goal is completed
    public override string DisplayGoal()
    {
        if(Completion){
            return $"[ ] Name: {Name} - Description: {Description} - Points: {PointValue}";
        }else
        {
            return $"[ ] Name: {Name} - Description: {Description} - Points: {PointValue} ";
        }
        
    }

    public override string FormatGoal()
    {
        return $"eternal|{Name}|{Description}|{PointValue}";
    }
}
