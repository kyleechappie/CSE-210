using System;

public class ChecklistGoal : Goal
{
    protected int timesForBonus { get; set; }

    protected int bonusValue { get; set; }

    protected int timesCompleted { get; set; }

    public ChecklistGoal(){

    }
    
    public ChecklistGoal(string name, string description, int pointValue, bool completion, int timesForBonus, int bonusValue, int timesCompleted){
        name = Name;
        description = Description;
        pointValue = PointValue;
        completion = Completion;
        timesForBonus = timesForBonus;
        bonusValue = bonusValue;
        timesCompleted = timesCompleted;
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
        if(Completion){
            return $"[X] Name: {Name} - Description: {Description} - Points: {PointValue} - Status: {timesForBonus}/{timesCompleted} - Bonus value: {bonusValue}";
        }
        else{
            return $"[ ] Name: {Name} - Description: {Description} - Points: {PointValue} - Status: {timesForBonus}/{timesCompleted} - Bonus value: {bonusValue}";
        }
        
    }

    public override void CompleteGoal(GoalManager goalManager)
    {
        timesForBonus += 1;
        if (timesForBonus == timesCompleted)
        {
            Completion = true;
            goalManager.addToScore(bonusValue);
        }
    
    }
    public override string FormatGoal()
    {
        return $"checklist|{Name}|{Description}|{PointValue}|{Completion}|{timesForBonus}|{timesCompleted}|{bonusValue}";
    }
}
