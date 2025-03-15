public class User
{
    public string _userName { get; set; }
    public int _acheivedPoints
    {
        get
        {
            int total = 0;
            foreach (Goal goal in goals)
            {
                total += goal.getAchievedPoints();
            }
            return total;
        }
    }
    public List<Goal> goals { get; set; }
    public User()
    {
        _userName = "New User";
        goals = new List<Goal>();
    }
    public void displayGoals()
    {
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. " + goal.displayGoal());
            i++;
        }
    }
    public void recordEvent(int goalIndex)
    {
        goals[goalIndex].updateProgress();
    }
}