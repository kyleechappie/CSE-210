using System;
using Develop04.Classes;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Mindfulness Journal.");

            while (true)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Goal Setting Activity");
                Console.WriteLine("5. Save");
                Console.WriteLine("6. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartBreathingActivity();
                        break;

                    case "2":
                        StartReflectionActivity();
                        break;

                    case "3":
                        StartListingActivity();
                        break;

                    case "4":
                        StartGoalSettingActivity();
                        break;

                    case "5":
                        Save();
                        break;

                    case "6":
                        Console.WriteLine("Exiting Mindfulness Journal. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void StartBreathingActivity()
        {
            Console.WriteLine("Starting Breathing Activity...");
            // create instance of the Breathing class and call the RunActivity method
            Breathing breathingActivity = new Breathing("Breathing Activity", "Recharge and relax as we guide you through a calming breath sequence. Clear your mind, and center yourself with focused, slow breaths.", 0);
            breathingActivity.RunBreathing();
        }

        static void StartReflectionActivity()
        {
            Console.WriteLine("Starting Reflection Activity...");
            // create instance of the Reflection class and call the RunActivity method
            Reflection reflectionActivity = new Reflection("Reflection Activity", "Reflect on your day and share your reflections with your family and friends.", 0);
            reflectionActivity.RunReflection();
        }

        static void StartListingActivity()
        {
            Console.WriteLine("Starting Listing Activity...");
            // create instance of the Listing class and call the RunActivity method
            Listing listingActivity = new Listing("Listing Activity", "Write down some things that happened today and share it with your family and friends.", 0);
            listingActivity.RunListing();
        }

        static void StartGoalSettingActivity()
        {
            Console.WriteLine("Starting Goal Setting Activity...");
            // create instance of the GoalSetting class and call the RunActivity method
            Goal goalSettingActivity = new Goal("Goal Setting Activity", "Set goals for yourself and share your goals with your family and friends.", 0);
            goalSettingActivity.RunGoals();
        }

        static void Save()
        {
            Console.WriteLine("Saving your Mindfulness Journal...");
            // add logic for saving journal data
        }
    }
}
