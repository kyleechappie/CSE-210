using System;

namespace Develop04.Classes
{
    public class Activity
    {
        private int userInputDuration;

        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public Activity(string name, string description, int duration)
        {
            Name = name;
            Description = description;
            Duration = duration;
        }

        public void Intro()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Description}");
            Console.WriteLine("Set your preferred duration for this activity in seconds:");

            // Handle user input for duration
            // while (!int.TryParse(Console.ReadLine(), out userInputDuration) || userInputDuration <= 0)
            // // userInputDuration wasnt working so i used out... hope i dont regret it
            // {
            //     Console.WriteLine("Invalid input. Please enter a positive integer for duration:");
            // }

            Duration = int.Parse(Console.ReadLine());

            Console.WriteLine($"Duration set to {Duration} seconds");

            // Simulate a loading screen
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(2000); // Sleep for 2 seconds 

            // Continue with the activity
            Console.WriteLine("Let's begin!");
        }

        public void Ending()
        {
            Console.WriteLine("Congratulations on completing this mindful activity! Until next time, nurture your well-being and embrace the present moment.");
        }
    }
}



