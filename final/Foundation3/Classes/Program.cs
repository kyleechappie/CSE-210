//COMPLETE

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("123 Oak Lane", "Pelican Town", "Stardew Valley", "12345", "Germany");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Town Council Meeting", "Meeting to discuss Community Center renovation", "Spring 13, 2001", "10:00 am - 11:00 pm", $"{lectureAddress}", "Lecture", "Mayor Lewis", 7);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("1304 Bristlewood Dr.", "McKinney", "TX", "75070", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Annalee and Easton", "Annalee and Eastons wedding reception", "June 2, 2024", "6:00 pm - 12:00am", $"{receptionAddress}", "Reception", "wright@gmail.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("5812 Heronrise Crecent Dr.", "Lithia", "FL", "33547", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Pool Party", "A pool party for some cool cats :)", "July 20, 2024", "12:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}