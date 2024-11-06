using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        //New List
        List<int> numbers = new List<int>();
        int number;
        int sumList = 0;
        int count = 0;
        int large = 0;
        float average = 0;

        do
        {
            Console.Write("Enter number: ");
            string numberS = Console.ReadLine();
            number = int.Parse(numberS);

            //We add the number to the list if number is different than 0
            if (number != 0) { numbers.Add(number); count = count + 1; }
        } while (number != 0);

        //Calculating list
        int small = numbers[0];
        foreach (int record in numbers)
        {
            sumList = sumList + record;
            if (record > large) { large = record; }
            if (record < small && record > 0) { small = record; }
        }

        //Average
        average = (float)sumList / (float)count;

        //Sorting list
        numbers.Sort();

        Console.WriteLine("");
        Console.WriteLine($"The sum is: {sumList}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");
        Console.WriteLine($"The smallest positive number is: {small}");
        Console.WriteLine("");
        Console.WriteLine("The sorted list is:");
        foreach (int record in numbers)
        {
            Console.WriteLine($"{record}");
        }

        //Console.WriteLine("Hello Prep4 World!");
    }
}