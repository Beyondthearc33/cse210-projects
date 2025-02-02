using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.CompilerServices;
using System.Net;

class Program
{
    public static List<PromptResponse> responses = new List<PromptResponse>();


    public static void Write()
    {
        Entry entry = new Entry();
        entry.Display();
        entry.Response();
        responses.Add(entry.GetEntry());
    }
    public static void Display()
    {
        foreach (PromptResponse promptResponse in responses)
        {
            Console.WriteLine($"Date: {promptResponse.Date} - Prompt: {promptResponse.Prompt}");
            Console.WriteLine(promptResponse.Response);
            Console.WriteLine();
        }


    }

    public static void Load()
    {
        Console.WriteLine("What is the filename?");
        String loadFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public static void Save()
    {
        Console.WriteLine("What is the filename?");
        String fileName = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            foreach (PromptResponse promptResponse in responses)
            {
                outputFile.WriteLine($"Date: {promptResponse.Date} - Prompt: {promptResponse.Prompt}");
                outputFile.WriteLine(promptResponse.Response);
                outputFile.WriteLine();
            }
        }
    }


    public static String Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string menuResponse = Console.ReadLine();
        return menuResponse;
    }

    static void Main(string[] args)
    {

        string menuResponse;

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            menuResponse = Menu();

            switch (menuResponse)
            {
                case "1":
                    Write();
                    break;
                case "2":
                    Display();
                    break;
                case "3":
                    Load();
                    break;
                case "4":
                    Save();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("ERROR, Please type a Number");
                    break;
            }
        } while (menuResponse != "5");
    }


}