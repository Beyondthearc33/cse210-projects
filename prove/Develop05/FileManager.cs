using System.Runtime.CompilerServices;

public class FileManager
{
    public static void saveUserGoals(List<Goal> goals, string fileName, string userName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(userName);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.fileString());
            }
        }
    }
    public static void loadUserGoals(User user, string fileName)
    {
        user._userName = "New User";
        user.goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        user._userName = lines[0];
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];
            switch (goalType)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.parseFileString(parts);
                    user.goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.parseFileString(parts);
                    user.goals.Add(eternalGoal);
                    break;
                case "CheckListGoal":
                    CheckListGoal checkListGoal = new CheckListGoal();
                    checkListGoal.parseFileString(parts);
                    user.goals.Add(checkListGoal);
                    break;
                default:
                    break;
            }
        }
    }
}