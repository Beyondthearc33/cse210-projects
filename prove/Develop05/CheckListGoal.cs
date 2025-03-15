public class CheckListGoal : Goal
{
    private int _numberOfCompletions;
    private int _bonusTarget;
    private int _bonusPoints;
    public CheckListGoal() : base()
    {
        _numberOfCompletions = 0;
        _bonusTarget = 0;
        _bonusPoints = 0;
    }
    public CheckListGoal(string name, string description, int points) : base(name, description, points) //Constructor
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public CheckListGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public override void initializeFromConsole()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusTarget = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string displayGoal()
    {
        return $"{(_numberOfCompletions == _bonusTarget ? "[x]" : "[ ]")} {_name} ({_description}) -- Currently completed: {_numberOfCompletions}/{_bonusTarget}";
    }
    public override void updateProgress()
    {
        _numberOfCompletions++;
    }
    public int getPoints()
    {
        int totalPoints = _points * _numberOfCompletions;
        if (_numberOfCompletions >= _bonusTarget)
        {
            totalPoints += _bonusPoints;
        }
        return totalPoints;
    }
    public override int getAchievedPoints()
    {
        return (_points * _numberOfCompletions) + (_numberOfCompletions >= _bonusTarget ? _bonusPoints : 0);
    }
    public override string fileString()
    {
        return $"CheckListGoal,{_name},{_description},{_numberOfCompletions},{_bonusTarget},{_points},{_bonusPoints}";
    }
    public override void parseFileString(string[] fileLine)
    {
        _name = fileLine[1];
        _description = fileLine[2];
        _numberOfCompletions = int.Parse(fileLine[3]);
        _bonusTarget = int.Parse(fileLine[4]);
        _points = int.Parse(fileLine[5]);
        _bonusPoints = int.Parse(fileLine[6]);
    }
}