using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Maple Dr", "Lima", "Lima", "USA");

        Lecture lecture = new Lecture("How to pick up chicks", "A presentation on how to find your future babe: presented by none other than President Meredith", "March 29, 2024", "11 AM", address, "President Meredith", 450);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("456 Oak Ln", "Los Olivos", "Lima", "Canada");

        Reception reception = new Reception("Annalee and Eastons Wedding Reception", "Really cute wedding I so happy for them", "June 20, 2024", "12 PM", addressR, "wedding@gmail.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("789 Pine Xing", "Cusco", "Cusco", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Festival Inti Raymi", "The Celebration of the Sun", "September 16, 2023", "9 PM", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}