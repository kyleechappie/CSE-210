public class Journal
{
    public void saveEntry(string sentenceWithoutSpaces, string entry)
    {
        using (StreamWriter outputFile = new StreamWriter(sentenceWithoutSpaces))
        {
            // append the entry to the file
            outputFile.WriteLine(entry);
        }
    }
    public void LoadEntry(){

    }
    public void fileName(){
        Console.WriteLine("What is the name of the text file:");
    }
    public void formatFile(string File){
        Console.WriteLine($"{File}.txt");
    }
    public void printStatement(string file){
        Console.WriteLine($"Your Journal has been saved to {file}");
    }
}


