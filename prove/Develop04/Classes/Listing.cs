using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Listing : Activity
    {
        public Listing(string name, string description, int duration)
            : base("Listing Activity", "This activity will help you reflect on past events in your life. Write down your thoughts and feelings.", duration)
        {
        }

        public new void Intro()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Description}");
            Console.WriteLine("Set your preferred duration for this breathing activity in seconds:");

            // user input for duration
            while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for duration:");
            }

            Console.WriteLine($"Duration set to {Duration} seconds");

            // Simulate a loading screen
            Console.WriteLine("Loading...");
            Thread.Sleep(2000); // Sleep for 2 seconds (you can adjust the duration)

            //add listing activity here

            // Ending message
            Ending();
        }
    }
}
