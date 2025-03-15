using System.Globalization;
using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{
    private int _numberOfCompletions;
    public EternalGoal() : base()
    {
        _numberOfCompletions = 0;
    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public EternalGoal(string name, string description, int points, int numberOfCompletions) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _numberOfCompletions = numberOfCompletions;
    }
    public override void updateProgress()
    {
        _numberOfCompletions++;
    }

    public override int getAchievedPoints()
    {
        return _points * _numberOfCompletions;
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
        return $"[ ] {_name} ({_description})";
    }
    public override string fileString()
    {
        return $"EternalGoal,{_name},{_description},{_numberOfCompletions},{_points}";
    }
    public override void parseFileString(string[] fileLine)
    {
        _name = fileLine[1];
        _description = fileLine[2];
        _numberOfCompletions = int.Parse(fileLine[3]);
        _points = int.Parse(fileLine[4]);
    }
}