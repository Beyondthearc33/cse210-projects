using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        int userInput;  
        Console.Clear();
       do {
        Console.WriteLine($"You have {user._acheivedPoints} points.\n");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string input = Console.ReadLine();
        userInput = int.Parse(input);
        switch (userInput)
        {
            case 1:
                displayNewGoalOptions();
                string goalType = Console.ReadLine();
                createNewGoal(goalType, user);
                break;
            case 2:
                Console.WriteLine("\n");
                user.displayGoals();
                Console.WriteLine("\n");
                break;
            case 3:
                // Save Goals
                break;
            case 4:
                // Load Goals
                break;
            case 5:
                Console.WriteLine("\n");
                Console.WriteLine("The goals are: ");
                user.displayGoals();
                Console.WriteLine("Which goal did you accomplish?");
                int goalIndex = int.Parse(Console.ReadLine());
                goalIndex--;
                user.recordEvent(goalIndex);
                Console.WriteLine("\n");
                
                break;
            case 6:
                // Quit
                Environment.Exit(0);
                break;
            default:
            Console.WriteLine("Invalid Input, Try Again");
                break;
        }
        }
            while (userInput != 6);


    }

    public static void displayNewGoalOptions()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
    }
    public static void createNewGoal(string goalType, User user)
    {
        switch(goalType)
        {
            case "1":
            Console.WriteLine("Simple Goal\n\n");
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.initializeFromConsole();
            user.goals.Add(simpleGoal);
                break;
            case "2":
            Console.WriteLine("Eternal Goal\n\n");
                break;
            case "3":
            Console.WriteLine("Checklist Goal\n\n");
                break;
        }
    }

}