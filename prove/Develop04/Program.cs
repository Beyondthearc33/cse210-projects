using System;

class Program
{

    public void menu()
    {

    }
    static void Main(string[] args)
    {
        string input;
        int userInput;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            userInput = int.Parse(input);

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Option 1");
                    BreathingActivity breathingActivity = new BreathingActivity();

                    breathingActivity.startMessage();
                    breathingActivity.beginActivity();
                    breathingActivity.endMessage();
                    breathingActivity.affirmationMessage();
                    break;
                case 2:
                    Console.WriteLine("Option 2");
                    ReflectingActivity reflectingActivity = new ReflectingActivity();

                    reflectingActivity.startMessage();
                    reflectingActivity.beginActivity();
                    reflectingActivity.endMessage();
                    reflectingActivity.affirmationMessage();
                    break;
                case 3:
                    Console.WriteLine("Option 3");
                    ListingActivity listingActivity = new ListingActivity();

                    listingActivity.startMessage();
                    listingActivity.beginActivity();
                    listingActivity.randomPromptSelector();
                    listingActivity.endMessage();
                    listingActivity.affirmationMessage();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        while (userInput != 4);
    }
}