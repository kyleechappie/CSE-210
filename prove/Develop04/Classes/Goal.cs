using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Goal : Activity
    {
        public Goal(string name, string description, int duration)
            : base("Goal Making Activity", "Set a goal and track your progress towards it. Set a goal and track your progress towards it. Set a goal and track your progress towards it.", duration)
        {
        }
        public void RunGoals()
        {
            Intro();
        }

        private static void RunActivity()
        {
            throw new NotImplementedException();
        }

        private static void RunGoals1(Goal @this)
        {
            @this.Intro();

            // Goal making activity
            Console.WriteLine("Let's set a SMART goal:");

            Console.Write("What goal are you setting? ");
            string goal = Console.ReadLine();

            Console.Write("Specific: ");
            Console.Write("What can you do to make this goal a more specific? ");
            string specific = Console.ReadLine();

            Console.Write("Measurable: ");
            Console.Write("How can you measure progress towards this goal? ");
            string measurable = Console.ReadLine();

            Console.Write("Achievable: ");
            Console.Write("Is this goal achievable? ");
            string achievable = Console.ReadLine();

            Console.Write("Relevant: ");
            Console.Write("Is this goal relevant to your life? ");
            string relevant = Console.ReadLine();

            Console.Write("Time-bound: ");
            Console.Write("Does this goal have an upper time limit? When do you want to acheive this goal by?");
            string timeBound = Console.ReadLine();

            Console.WriteLine("Great! You've set a SMART goal:");

            Console.WriteLine($"Specific: {specific}");
            Console.WriteLine($"Measurable: {measurable}");
            Console.WriteLine($"Achievable: {achievable}");
            Console.WriteLine($"Relevant: {relevant}");
            Console.WriteLine($"Time-bound: {timeBound}");
            @this.

                            // Ending message
                            Ending();
        }
    }
}