using System;
using System.Threading;

namespace Develop04.Classes
{
    public class Reflection : Activity
    {
        public Reflection(string name, string description, int duration) 
            : base("Reflections Activity", "Reflect on your day and share your reflections with your family and friends.", duration)
        {
        }
        public void RunReflection()
        {
            Intro();

        //add reflection activity here

            // Ending message
            Ending();
        }

      
    }
}