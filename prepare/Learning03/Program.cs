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
        Fraction basic = new Fraction();
        Fraction wholeNumber = new Fraction(top);
        Fraction fraction02 = new Fraction(top, bottom);

        Console.WriteLine(basic.GetDecimalValue());
        Console.WriteLine(basic.GetFractionString());
        basic.SetTop(2);
        Console.WriteLine(basic.GetDecimalValue());
        Console.WriteLine(basic.GetFractionString());

        Console.WriteLine(wholeNumber.GetDecimalValue());
        Console.WriteLine(wholeNumber.GetFractionString());
        wholeNumber.SetTop(14);
        Console.WriteLine(wholeNumber.GetDecimalValue());
        Console.WriteLine(wholeNumber.GetFractionString());
    }
    
}