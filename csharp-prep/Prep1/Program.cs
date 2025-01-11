using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your First Name?");
        String firstName = Console.ReadLine();
        
        Console.WriteLine(" Whatis your Last Name?");
        String lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}