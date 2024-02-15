using System;
using System.Collections.Generic;

public class Scripture
{
    private string reference;
    private string text;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        InitializeWords();
    }

    private void InitializeWords()
    {
        words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{reference}: {text}");
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (var word in words)
        {
            if (!word.IsHidden && random.Next(2) == 0) // 50% chance to hide a word
            {
                word.Hide();
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.TrueForAll(word => word.IsHidden);
    }
}
