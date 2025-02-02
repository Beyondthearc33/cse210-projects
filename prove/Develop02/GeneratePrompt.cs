using System;
using System.Dynamic;

class GeneratePrompt
{
    public List<String> _promptList = new List<String>();
    
public GeneratePrompt() // Constructor
{
_promptList.Add("Who was the most interesting person I interacted with today?");
_promptList.Add("What was the best part of my day?");
_promptList.Add("How did I see the hand of the Lord in my life today?");
_promptList.Add("What was the strongest emotion I felt today?");
_promptList.Add("If I had one thing I could do over today, what would it be?");
_promptList.Add("What is a major difference in your life from a year ago?");
_promptList.Add("What is your relationship with your family?");
_promptList.Add("Tell me about one place you went today?");

}
    public String GetPrompt() // Grab a random prompt and return it.
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _promptList.Count);
        return _promptList[randomNumber];
    }
}