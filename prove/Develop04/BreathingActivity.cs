using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

public class BreathingActivity : Activity
{
    private const string _name = "Breathing Activity";
    private const string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
    public BreathingActivity() : base(_name, _description)
    {

    }
    public override void beginActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        loadingSpinner();
        Console.WriteLine("");
        breatheInOut();
        Console.WriteLine("\nWell Done!!");
        loadingSpinner();
    }

    public override void affirmationMessage()
    {
        Console.WriteLine("\n“Take a moment to appreciate this breath—steady, calm, and present. Carry this sense of clarity and relaxation with you, knowing that just a few deep breaths can reset your mind anytime, anywhere. Breathe easy, move forward, and embrace the moment.”");
        Thread.Sleep(10000);
    }

    public int getNumberOfBreathingExersizes()
    {
        int breaths = _time / 10;
        return breaths;
    }

    public void breatheInOut()
    {
        for (int i = 1; i <= getNumberOfBreathingExersizes(); i++)
        {
            Console.Write("\nBreathe in...");
            for (int j = 5; j >= 1; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow breathe out...");

            for (int j = 5; j >= 1; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\n");
        }
    }

}