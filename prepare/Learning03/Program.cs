using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        Console.WriteLine("Testing fractions encapsulations");
        Console.WriteLine("");

        //Crating new fraction
        Fraction fraction = new Fraction();
        fraction.SetTop(1);
        fraction.SetBottom(3);

        //Showing results
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}