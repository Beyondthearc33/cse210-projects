using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers;
        numbers = new List<int>();
        int? number = null;


        while (number != 0)
        {

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            String numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            numbers.Add(number.Value);
        }

        int numbersSum = numbers.Sum();
        Console.WriteLine("The sum is: " + numbersSum);

        double numbersAverage = numbers.Average();
        Console.WriteLine("The average is: " + numbersAverage);

        int numbersMax = numbers.Max();
        Console.WriteLine("The largest number is: " + numbersMax);
    }

}