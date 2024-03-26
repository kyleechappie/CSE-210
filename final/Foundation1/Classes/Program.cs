// ARTICULATION PROJECT

//Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). 
//Put each of these videos in a list.

// also disclaimer!!! these comments/videos are based off of a game called stardew valley. theyre meant to be silly and are based off of the games characters

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // video 1
        Video video1 = new Video("I MADE A GOLDEN STATUE OF MYSELF", "Mayor Lewis", 384);

        Comment video1Comment1 = new Comment("Abigail", "This video is truly repulsive! Thanks a lot for ruining my day!");
        Comment video1Comment2 = new Comment("Robin", "So this is where our tax dollars are going! Good to know!");
        Comment video1Comment3 = new Comment("Leah", "Wow! All that money for a less than decent looking statue! Couldn't even hire any local artists for that huh!?!");
        Comment video1Comment4 = new Comment("Marnie", "I still luv you!!!");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // video 2
        Video video2 = new Video("Cooking With Gus", "Gus", 984);

        Comment video2Comment1 = new Comment("Pam", "Gus you are an angel sent from heaven! you make the best food!");
        Comment video2Comment2 = new Comment("Maru", "You make the best pepper poppers! I'll have to try this recipe!");
        Comment video2Comment3 = new Comment("Linus", "I can always count on you Gus! You da best!");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // video 3
        Video video3 = new Video("Emily: The One That Got Away", "Clint", 845);

        Comment video3Comment1 = new Comment("Emily", "I'm truly disgusted Clint.");
        Comment video3Comment2 = new Comment("Elliot", "Digital footprint...");
        Comment video3Comment3 = new Comment("Haley", "EWWW Stay away from my sister you smelly smelly man!");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
