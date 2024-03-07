using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Listing : Activity
    {
        public Listing(string name, string description, int duration) 
            : base("Listing Making Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
        {
        }
        public void RunGoals()
        {
            Intro();

        //add goal making activity here

            // Ending message
            Ending();
        }
    }
}