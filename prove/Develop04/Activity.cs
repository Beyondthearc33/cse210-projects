public abstract class Activity
{
    protected int _time;
    private string _activityName;
    private string _activityDescription;

    public Activity()
    {

    }
    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public Activity(int time, string name, string description)
    {
        _time = time;
        _activityName = name;
        _activityDescription = description;
    }

    public abstract void beginActivity();

    public abstract void affirmationMessage();

    public void loadingSpinner()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void countDownTimer()
    {
        Console.Write("Get ready...");

        for (int i = 5; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void startMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n");

        Console.WriteLine(_activityDescription);

        Console.Write("\nHow long, in seconds, would you like for your session? ");

        _time = int.Parse(Console.ReadLine());
    }

    public void endMessage()
    {
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityName}.");
        loadingSpinner();
    }
}