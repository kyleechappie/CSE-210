using System.Threading;

namespace Develop04.Classes
{
    public class Listing : Activity
    {
        public Listing(string name, string description, int duration)
            : base(name, description, duration)
        {
        }

        public override void RunActivity()
        {
            // Add listing activity here

            // Ending message
            Ending();
        }
    }
}