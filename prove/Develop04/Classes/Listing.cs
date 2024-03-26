using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Listing : Activity
    {
        private int userDuration;

        public Listing(string name, string description, int duration) 
            : base("Listing Making Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
        {
        }
        public void RunListing()
        {
            Intro();

        //add listing making activity here

        if (userDuration > 0)
            {
                Duration = userDuration;
            }

            // Random prompt selection
            string[] prompts = {
                "Who are people that you appreciate?",
                "What are your personal strengths?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random random = new Random();
            string selectedPrompt = prompts[random.Next(prompts.Length)];

            // Display prompt
            Console.WriteLine(selectedPrompt);
            Console.WriteLine($"You have {Duration} seconds to think about the prompt.");
            Thread.Sleep(Duration * 1000);

            // User listing items
            Console.WriteLine("Start listing items:");

            // Record start time for duration calculation
            DateTime startTime = DateTime.Now;

            int itemCounter = 0;
            while ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                string listItem = Console.ReadLine();
                itemCounter++;
            }

            // Display number of items entered
            Console.WriteLine($"You listed {itemCounter} items.");

            // Ending message
            Ending();
        }


    }
}