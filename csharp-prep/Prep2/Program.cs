using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your Grade Percentage?");
        String gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        String letter;

        if (percentage >= 90) 
        {
            letter = "A";
        }
        else if (percentage >= 80) 
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
    if (percentage >= 60)
    {
        Console.WriteLine("You passed");
    } else 
    {
        Console.WriteLine("You Failed");
    }

        Console.WriteLine("Your letter grade is " + letter);
    }
}