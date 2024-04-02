using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List <Goal> ListOfGoals = new List<Goal>();
        GoalManager goalManager = new GoalManager();

        bool exitProgram = false;


       

        while (!exitProgram)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();// above is just for looks
            Console.WriteLine($"You have {goalManager.getScore()} points");
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. View Rank");
            Console.WriteLine("0. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    // add menu for creating different types of goals
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Select the type of goal you would like to create:");

                    string goalType = Console.ReadLine();

                    switch (goalType)
                    {
                        case "1":
                            // create a simple goal
                            // SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.DisplayGoalInformation();
                            ListOfGoals.Add(simpleGoal);
                            break;
                        case "2":
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.DisplayGoalInformation();
                            ListOfGoals.Add(eternalGoal);
                            // create an eternal goal
                            break;
                        case "3":
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.DisplayGoalInformation();
                            ListOfGoals.Add(checklistGoal);
                            // create a checklist goal
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;


                case "2":
                    //list goals
                    foreach (Goal goal in ListOfGoals)
                    {
                        Console.WriteLine(goal.DisplayGoal());
                    }

            
                    break;
                case "3":
                    //save goals
                    goalManager.SaveGoals(ListOfGoals, "goals.txt");
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    //load goals
                    //create load goals function that will read from goals.txt and append to list
                    
                        // check if file exists
                        if (!File.Exists("goals.txt"))
                        {
                            Console.WriteLine("File does not exist.");
                           
                        }

                    string[] lines = System.IO.File.ReadAllLines("goals.txt");


                    foreach (string line in lines)
                    {

                        string[] parts = line.Split('|');
                        
                        string goalType = parts[0];
                        if(goalType == "simple")
                        {
                           
                        }
                        else if(goalType == "eternal")
                        {
                            
                        }
                        else if(goalType == "checklist")
                        {
                            
                        }
                        
                    }
                    // call LoadGoals method
                    // List<Goal> goals = new List<Goal>(); // Create a list to store the goals
                    // goalManager.LoadGoals(goals, "goals.txt");
                    Console.WriteLine("Goals loaded successfully.");

                    break;
                case "5":
                    //record event
                    int count = 0;
                    foreach (Goal goal in ListOfGoals)
                    {   count += 1;
                        Console.WriteLine($"{count}. {goal.DisplayGoal()}");
                    
                    }
                    Console.WriteLine("Which goal did you accomplish?: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    ListOfGoals[option-1].CompleteGoal(goalManager); 
                    break;
                case "6":
        
                    // view rank
                    break;
                case "0":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
