using System;

class Program
{
    static void Main(string[] args)
    {
        //Getting variable data
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        //Console.WriteLine("Hello Prep1 World!");
        //New Line
        Console.WriteLine("");
        //Printing result
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
    }
}