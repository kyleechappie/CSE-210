//this class will display the rank when user inputs 6
    // rankings Novice Dreamer: 0 - 999 points
    // Epic Adventurer: 1000 - 1999 points
    // Quest Champion: 2000 - 4999 points
    // Goal Guru: 5000 - 9999 points
    // Master Achiever: 10000 and above points


//i could insert something that will display their next ranking that they are reaching for
using System;

public class Ranking
{
    public static void Rank()
    {
        Console.WriteLine("Enter your points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        string rank;

        if (points >= 0 && points <= 999)
        {
            rank = "Novice Dreamer";
        }
        else if (points >= 1000 && points <= 1999)
        {
            rank = "Epic Adventurer";
        }
        else if (points >= 2000 && points <= 4999)
        {
            rank = "Quest Champion";
        }
        else if (points >= 5000 && points <= 9999)
        {
            rank = "Goal Guru";
        }
        else
        {
            rank = "Master Achiever";
        }

        Console.WriteLine($"Your rank is: {rank}");
    }


}