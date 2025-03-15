public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
    }
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public abstract void initializeFromConsole();
    public abstract void updateProgress();
    public abstract int getAchievedPoints();
    public abstract string displayGoal();
    public abstract string fileString();
    public abstract void parseFileString(string[] fileLine);



















    // public void newGoalMenu()
    // {

    //     Console.WriteLine("they Types of Goals are:");
    //     Console.WriteLine("   1. Simple Goal");
    //     Console.WriteLine("   2. Eternal Goal");
    //     Console.WriteLine("   3. Checklist Goal");
    //     Console.WriteLine("Which type of goal would like to create?");

    //     do
    //     {

    //     }
    // }

    // public abstract void newGoal();

}