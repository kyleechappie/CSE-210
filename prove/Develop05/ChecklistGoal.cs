using System;

public class ChecklistGoal : Goal
{
    protected int _timesForBonus { get; set; }

    protected int _bonusValue { get; set; }

    protected int _timesCompleted { get; set; }

    public ChecklistGoal(){

    }
    
    public ChecklistGoal(string name, string description, int pointValue, bool completion, int timesForBonus, int bonusValue, int timesCompleted){
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _completion = completion;
        _timesForBonus = timesForBonus;
        _bonusValue = bonusValue;
        _timesCompleted = timesCompleted;
    }
    public override void DisplayGoalInformation()
    {
        // Call base class method to display inherited questions
        base.DisplayGoalInformation();

        // Display additional questions
        Console.WriteLine("How many times do you need to accomplish this goal to receive a bonus?");
        Console.Write("Times for bonus: ");
        int timesForBonus = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        Console.Write("Bonus value: ");
        int bonusValue = Convert.ToInt32(Console.ReadLine());

        // where can i access these goals??
    
    }
    public override string DisplayGoal()
    { 
        if(_completion){
            return $"[X] Name: {_name} - Description: {_description} - Points: {_pointValue} - Status: {_timesForBonus}/{_timesCompleted} - Bonus value: {_bonusValue}";
        }
        else{
            return $"[ ] Name: {_name} - Description: {_description} - Points: {_pointValue} - Status: {_timesForBonus}/{_timesCompleted} - Bonus value: {_bonusValue}";
        }
        
    }

    public override void CompleteGoal(GoalManager goalManager)
    {
        _timesForBonus += 1;
        if (_timesForBonus == _timesCompleted)
        {
            _completion = true;
            goalManager.addToScore(_bonusValue);
        }
    
    }
    public override string FormatGoal()
    {
        return $"checklist|{_name}|{_description}|{_pointValue}|{_completion}|{_timesForBonus}|{_timesCompleted}|{_bonusValue}";
    }
}
