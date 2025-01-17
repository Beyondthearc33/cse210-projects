using System;
using System.Globalization;

class Program
{
static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}

static String PromptUserName() {
    Console.WriteLine("Please Enter your name: ");

    String userName = Console.ReadLine();
    return userName;
}

static int PromptUserNumber() {
    Console.WriteLine("Please enter your favorite number: ");
    string userNumber = Console.ReadLine();

    int userNumberInput = int.Parse(userNumber);
    return userNumberInput;
}

static int SquareNumber(int userNumberInput) {
    return userNumberInput * userNumberInput;
}

static void DisplayResult(String userName, int userNumberInput) {
    Console.WriteLine($"Brother {userName}, the square of your number is {userNumberInput}");
}
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

       String userName =  PromptUserName();

       int userNumber = PromptUserNumber();

       int squareNumber = SquareNumber(userNumber);

       DisplayResult(userName, squareNumber);
    }
}