using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal() : base() //Constructor
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points) //Constructor
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public override void initializeFromConsole()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public override string displayGoal()
    {
        return $"{(_isComplete ? "[x]" : "[ ]")} {_name} ({_description})";
    }
    public override void updateProgress()
    {
        _isComplete = true;
    }
    public override int getAchievedPoints()
    {
        if (_isComplete)
        {
            return _points;
        }
        return 0;
    }
    public override string fileString()
    {
        return $"SimpleGoal,{_name},{_description},{_isComplete},{_points}";
    }
    public override void parseFileString(string[] fileLine)
    {
        _name = fileLine[1];
        _description = fileLine[2];
        _isComplete = bool.Parse(fileLine[3]);
        _points = int.Parse(fileLine[4]);
    }
}