using System;
using System.IO;

static void Main(string[] args)
{
    Journal journal = new Journal();
    string userChoice = "1";
    
    while (userChoice != "5")

    Console.WriteLine("Welcome to your journal");
    Console.WriteLine("Please select one of the following choices:");
    Console.Writeline("1. Write");
    Console.Writeline("2. Display");
    Console.Writeline("3. Load");
    Console.Writeline("4. Save");
    Console.Writeline("5. Quit");

    Console.Write("What would you like to do? ");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
        //Write
        //suggests different prompts
            PromptGenerator promptGenerator = new PromptGenerator();
            string prompt = promptGenerator.GetRandomPrompt();
            string response = Console.ReadLine();
            
            //Entry
            Entry entry = new Entry();
            entry._prompt = prompt;
            entry._response = response;
            entry._entryDate = DateTime.Now;

            //Journal
            journal._entries.Add(entry);
            break;

        case "2":
            foreach (Entry singleEntry in journal._entries)
            {
                Console.Write($"{singleEntry._prompt} {singleEntry._response} {singleEntry._entryDate}");
            }
            Console.WriteLine("Display");

            break;
        case "3":
            Console.WriteLine("Load");
            break;
        case "4":
            Console.WriteLine("Save");
            journal.Save();
            Console.WriteLine("File saved.");
            break;
        case "5":
            Console.WriteLine("Quit");
            exitProgram = true;
                    break;
            break;
        default:
    }

}
