using System;

public class EternalGoal : Goal
{

    public EternalGoal()
    {
        
    }

    public EternalGoal(string name, string description, int pointValue) //whats the ish??
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }
    //if goal is completed add points to score
        public override void CompleteGoal(GoalManager goalManager)
    {
        _completion = false;
        goalManager.addToScore(_pointValue);


    }
    // will not check box if goal is completed
    public override string DisplayGoal()
    {
        if(_completion){
            return $"[ ] Name: {_name} - Description: {_description} - Points: {_pointValue}";
        }else
        {
            return $"[ ] Name: {_name} - Description: {_description} - Points: {_pointValue} ";
        }
        
    }

    public override string FormatGoal()
    {
        return $"eternal|{_name}|{_description}|{_pointValue}";
    }
}
