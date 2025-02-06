using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        int top = 7;
        int bottom = 4;
        Fraction fraction = new Fraction(top, bottom);

        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionString());
    }
}