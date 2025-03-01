using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private const string _name = "Reflecting Activity";
    private const string _description = "This activity will help you reflect on times in your life when you have shown strength and reilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _reflectPrompts = new List<string>();

    private List<string> _deeperPrompts = new List<string>();

    public ReflectingActivity() : base(_name, _description)
    {

    }

    public override void beginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        loadingSpinner();
        Console.WriteLine("");
        displayReflectPrompt();
        displayDeeperPrompts();
        Console.WriteLine("\nWell done!!");
        loadingSpinner();
        Console.WriteLine("");
    }

    public override void affirmationMessage()
    {
        Console.WriteLine("\n“As you reflect, take a moment to acknowledge your thoughts without judgment. Every insight, big or small, is a step forward. Carry this awareness with you, and let it guide you toward growth, clarity, and peace.”");
        Thread.Sleep(10000);
    }

    public void addReflectPrompts()
    {
        _reflectPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectPrompts.Add("Think of a time when you did something really difficult.");
        _reflectPrompts.Add("Think of a time when you helped someone in need.");
        _reflectPrompts.Add("Think of a time when you did something truly selfless.");
    }

    public void addDeeperPrompts()
    {
        _deeperPrompts.Add("Why was this experience meaningful to you?");
        _deeperPrompts.Add("Have you ever done anything like this before?");
        _deeperPrompts.Add("How did you get started?");
        _deeperPrompts.Add("How did you feel when it was complete?");
        _deeperPrompts.Add("What made this time different than other times when you were not as successful?");
        _deeperPrompts.Add("What is your favorite thing about this experience?");
        _deeperPrompts.Add("What could you learn from this experience that applies to other situations?");
        _deeperPrompts.Add("What did you learn about yourself through this experience?");
        _deeperPrompts.Add("How can you keep this experience in mind in the future?");
    }
    public string randomReflectPromptSelector()
    {
        addReflectPrompts();
        Random random = new Random();
        int randomNumberOne = random.Next(0, _reflectPrompts.Count);

        string selectedReflectPrompt = _reflectPrompts[randomNumberOne];
        return selectedReflectPrompt;
    }

    public string randomDeeperPromptSelector()
    {
        addDeeperPrompts();
        Random random = new Random();
        int randomNumberOne = random.Next(0, _deeperPrompts.Count);

        string selectedDeeperPrompt = _deeperPrompts[randomNumberOne];
        return selectedDeeperPrompt;
    }

    public void displayReflectPrompt()
    {
        string prompt = randomReflectPromptSelector();
        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine($" --- {prompt} --- ");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");

        for (int j = 5; j >= 1; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();
    }
    public int numOfDeeperPrompts()
    {
        int numOfDeeperPrompts = _time / 15;
        return numOfDeeperPrompts;
    }

    public void displayDeeperPrompts()
    {
        for (int i = 1; i <= numOfDeeperPrompts(); i++)
        {
            string prompt = randomDeeperPromptSelector();
            Console.Write($"> {prompt} ");
            loadingSpinner();
            loadingSpinner();
            Console.WriteLine("");
        }
    }
}