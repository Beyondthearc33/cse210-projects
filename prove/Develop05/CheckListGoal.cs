public class CheckListGoal : Goal
{
    public override void updateProgress()
    {
        
    }

    public override void initializeFromConsole()
    {
        
    }
    public override string displayGoal()
    {
        return $"[] {_name} ({_description})";
    }
    public override int getAchievedPoints()
    {
        int acheivedPoints = 100;
        return acheivedPoints;
    }
}