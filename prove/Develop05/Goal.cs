//this is the inheritance class for the simple.cs checklist.cs and eternal.cs
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.CompilerServices;


public class Goal
{

    public string _name { get; set; }
    protected string _description { get; set; }
    protected int _pointValue { get; set; }
    protected bool _completion { get; set; }

    public virtual void CompleteGoal(GoalManager goalManager)
    {
       
    }

    public virtual void DisplayGoalInformation()
    {
        Console.WriteLine("What is the name of your goal?");
        Console.Write("Name: ");
        _name = Console.ReadLine(); 

        Console.WriteLine("Provide a short description of your goal");
        Console.Write("Description: ");
        _description = Console.ReadLine(); //see line 14

        Console.WriteLine($"How many points should be associated with your goal?");
        Console.Write("Points: ");
        _pointValue = Convert.ToInt32(Console.ReadLine()); //added int to beginning idk if that was a mistake

    }

    public virtual string DisplayGoal()
    {
        if(_completion){
            return $"[X] Name: {_name} - Description: {_description} - Points: {_pointValue}";
        }else
        {
            return $"[ ] Name: {_name} - Description: {_description} - Points: {_pointValue} ";
        }
        
    }

    public virtual string FormatGoal()
    {
        return"";
    }

}


