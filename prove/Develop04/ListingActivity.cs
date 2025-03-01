using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private const string _name = "Listing Activity";
    private const string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _listPrompts = new List<string>();
    private List<string> _responses = new List<string>();
    private bool _isTimeUp = false;

    public ListingActivity() : base(_name, _description)
    {

    }
    public override void beginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        loadingSpinner();
        Console.WriteLine("");
        showPrompt();
        listResponses();
        Console.WriteLine("\nWell done!!\n");
        loadingSpinner();
    }

    public override void affirmationMessage()
    {
        Console.WriteLine("\n“As you list your thoughts, ideas, or goals, remember that every word brings clarity and direction. Let this process help you organize your mind, focus your energy, and move forward with confidence.”");
        Thread.Sleep(10000);
    }

    public void showPrompt()
    {
        string selectedPrompt = randomPromptSelector();

        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine($" --- {selectedPrompt} --- ");
        Console.Write("You may begin in: ");

        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("1");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
    }

    public void addListPrompts()
    {
        _listPrompts.Add("Who are people that you appreciate?");
        _listPrompts.Add("What are personal strengths of yours?");
        _listPrompts.Add("Who are people that you have helped this week?");
        _listPrompts.Add("When have you felt the Holy Ghost this month?");
        _listPrompts.Add("Who are some of your personal heroes?");
    }

    public string randomPromptSelector()
    {
        addListPrompts();
        Random random = new Random();
        int randomNumber = random.Next(0, _listPrompts.Count);
        string selectedPrompt = _listPrompts[randomNumber];
        return selectedPrompt;
    }

    public void listResponses()
    {
        Console.Write("> ");
        Thread timer = new Thread(() =>
        {
            Thread.Sleep(_time * 1000);
            _isTimeUp = true;
        });

        timer.Start();

        while (!_isTimeUp)
        {
            if (Console.KeyAvailable)
            {
                _responses.Add(Console.ReadLine());
                Console.Write("> ");
            }
            if (_isTimeUp)
            {
                Console.Write("\b \b\n");
                break;
            }
        }
        Console.WriteLine($"You listed {_responses.Count()} items!");
    }
}