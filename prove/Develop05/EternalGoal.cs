public class EternalGoal : Goal{
    public override void updateProgress()
    {
        
    }
    public override int getAchievedPoints()
    {
        return 5; // Not Implemented yet
    }
    public override void initializeFromConsole()
    {
        
    }

    public override string displayGoal()
    {
        return $"[] {_name} ({_description})";
    }
}