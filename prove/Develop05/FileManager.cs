using System.Runtime.CompilerServices;

public class FileManager
{
    public void AddGoal(Goal goal)
    {
        //Goals.Add(goal)
    }

    public static void saveUserGoals(User user, string fileName)
    {

    }

    public static void loadUserGoals(User user, string fileName)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }



}