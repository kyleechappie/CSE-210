using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Breathing : Activity
    {
        public Breathing(string name, string description, int duration)
            : base("Breathing Activity", "Recharge and relax as we guide you through a calming breath sequence. Clear your mind, and center yourself with focused, slow breaths.", duration)
        {
        }

        public void RunBreathing()
        {
            Intro();
            // 4-7-8 breathing activity
            Console.WriteLine("Let's begin the 4-7-8 breathing exercise:");

            int breathCycle = Duration / 15; // Assuming 15 seconds per breath cycle

            for (int i = 0; i < breathCycle; i++)
            {
                Console.WriteLine($"Breath {i + 1}: Inhale for 4 seconds");
                Thread.Sleep(4000);

                Console.WriteLine($"Breath {i + 1}: Hold for 7 seconds");
                Thread.Sleep(7000);

                Console.WriteLine($"Breath {i + 1}: Exhale for 8 seconds");
                Thread.Sleep(8000);
            }

            // Ending message
            Ending();
        }
    }
}
