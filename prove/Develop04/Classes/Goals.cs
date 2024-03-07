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

        //add goal making activity here

            // Ending message
            Ending();
        }
    }
}
