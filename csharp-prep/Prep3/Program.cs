using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    
        Console.Write("What is the Magic Number? ");
       int magicNumber = Random.Next(1, 101);

        int? guess = null;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            String guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You Guessed it!");
    }
}