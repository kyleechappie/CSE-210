//this is the inheritance class for the simple.cs checklist.cs and eternal.cs
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.CompilerServices;


public class Goal
{

    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int PointValue { get; set; }
    protected bool Completion { get; set; }

    public virtual void CompleteGoal(GoalManager goalManager)
    {
       
    }

    public virtual void DisplayGoalInformation()
    {
        Console.WriteLine("What is the name of your goal?");
        Console.Write("Name: ");
        Name = Console.ReadLine(); 

        Console.WriteLine("Provide a short description of your goal");
        Console.Write("Description: ");
        Description = Console.ReadLine(); //see line 14

        Console.WriteLine($"How many points should be associated with your goal?");
        Console.Write("Points: ");
        PointValue = Convert.ToInt32(Console.ReadLine()); //added int to beginning idk if that was a mistake

    }

    public virtual string DisplayGoal()
    {
        if(Completion){
            return $"[X] Name: {Name} - Description: {Description} - Points: {PointValue}";
        }else
        {
            return $"[ ] Name: {Name} - Description: {Description} - Points: {PointValue} ";
        }
        
    }

    public virtual string FormatGoal()
    {
        return"";
    }

    // public virtual Goal Deserialize(string serializedGoal)
    // {
    //     string[] parts = serializedGoal.Split(',');
    //     Goal goal = new Goal();
    //     goal.Name = parts[0];
    //     goal.Description = parts[1];
    //     goal.PointValue = Convert.ToInt32(parts[2]);
    //     goal.Completion = Convert.ToBoolean(parts[3]);
    //     return goal;
    // }

}



