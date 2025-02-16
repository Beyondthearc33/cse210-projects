using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs";
        int chapter = 3;
        int verseBeginning = 5;
        int verseEnd = 6;
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Reference passage1 = new Reference(book, chapter, verseBeginning, verseEnd, text);

        Scripture scripture1 = new Scripture(passage1);

        string input = "";

        while (input.ToLower() != "quit")
        {
            Console.Clear();
            scripture1.Display();
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture1.IsAllWordsHidden())
            {
                scripture1.Quit();
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                scripture1.Advance();
                continue;
            }
        }
    }
}